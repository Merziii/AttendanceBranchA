Imports MySql.Data.MySqlClient

Public Class frmAttendanceA
    Dim BranchCode As String = "A" 'Change this for each branch (A, B, C, D)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Today.ToString("yyyy-MM-dd")
        txtDate.ReadOnly = True
        txtBranch.Text = "Branch " & BranchCode
        txtBranch.ReadOnly = True
        cboStatus.Items.AddRange({"Present", "Absent"})
        cboStatus.SelectedIndex = 0
        LoadAttendance()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterAttendance(txtSearch.Text.Trim)
    End Sub

    ' --- LOAD ALL RECORDS INTO GRID ---
    Private Sub LoadAttendance()
        Try
            Connect()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT * FROM attendance ORDER BY Date DESC", cn)
            da.Fill(dt)
            dgvAttendance.DataSource = dt
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAttendance.Columns("id").Visible = False
            lblStatus.Text = "Total records: " & dt.Rows.Count
        Catch ex As Exception
            MsgBox("Load error: " & ex.Message)
        End Try
    End Sub

    ' --- SAVE ATTENDANCE LOCALLY ---
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStudentID.Text.Trim = "" Or txtStudentName.Text.Trim = "" Then
            MsgBox("Please fill in Student ID and Name.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Try
            Connect()
            sql = "INSERT IGNORE INTO attendance (StudentID, StudentName, BranchCode, Date, Status, Synced) "
            sql &= "VALUES (@sid, @sname, @branch, @date, @status, 0)"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@sid", txtStudentID.Text.Trim)
            cmd.Parameters.AddWithValue("@sname", txtStudentName.Text.Trim)
            cmd.Parameters.AddWithValue("@branch", BranchCode)
            cmd.Parameters.AddWithValue("@date", txtDate.Text)
            cmd.Parameters.AddWithValue("@status", cboStatus.SelectedItem.ToString)
            Dim rows As Integer = cmd.ExecuteNonQuery()
            If rows > 0 Then
                MsgBox("Attendance saved!", MsgBoxStyle.Information)
                txtStudentID.Clear()
                txtStudentName.Clear()
                cboStatus.SelectedIndex = 0
                LoadAttendance()
            Else
                MsgBox("Duplicate entry blocked: " & txtStudentID.Text & " already recorded today.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Save error: " & ex.Message)
        End Try
    End Sub

    ' --- VIEW UNSYNCED RECORDS ---
    Private Sub btnViewUnsynced_Click(sender As Object, e As EventArgs) Handles btnViewUnsynced.Click
        Try
            Connect()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(
                "SELECT * FROM attendance WHERE Synced = 0 AND Date = CURDATE()", cn)
            da.Fill(dt)
            dgvAttendance.DataSource = dt
            lblStatus.Text = "Unsynced records today: " & dt.Rows.Count
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    '--- FILTER RECORDS IN GRID ---
    Private Sub FilterAttendance(keyword As String)
        Try
            Connect()
            Dim dt As New DataTable
            Dim cmd As New MySqlCommand(
            "SELECT * FROM attendance " &
            "WHERE StudentID LIKE @kw OR StudentName LIKE @kw " &
            "ORDER BY Date DESC", cn)
            cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            dgvAttendance.DataSource = dt
            lblStatus.Text = "Records found: " & dt.Rows.Count
        Catch ex As Exception
            MsgBox("Filter error: " & ex.Message)
        End Try
    End Sub


    ' --- SYNC TO SERVER ---
    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        Dim serverIP As String = "localhost"   ' <-- Server PC, change when at school
        Dim sent As Integer = 0
        Dim skipped As Integer = 0
        Try
            ' 1. Get unsynced records from local DB
            Connect()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(
                "SELECT * FROM attendance WHERE Synced = 0 AND Date = CURDATE()", cn)
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No unsynced records to send today.", MsgBoxStyle.Information)
                Exit Sub
            End If
            ' 2. Connect to Server
            Dim serverCn As New MySqlConnection(
                "server=" & serverIP & ";user=root;password=;database=attendance_server;Connect Timeout=5")
            Try
                serverCn.Open()
            Catch ex As Exception
                MsgBox("Cannot reach the server. Please check the connection and try again." & vbCrLf &
           "Your local records are safe and will sync later.",
           MsgBoxStyle.Exclamation, "Server Unreachable")
                Exit Sub
            End Try
            ' 3. Send each record
            For Each row As DataRow In dt.Rows
                Try
                    Dim serverCmd As New MySqlCommand(
                        "INSERT IGNORE INTO attendance (StudentID, StudentName, BranchCode, Date, Status) " &
                        "VALUES (@sid, @sname, @branch, @date, @status)", serverCn)
                    serverCmd.Parameters.AddWithValue("@sid", row("StudentID"))
                    serverCmd.Parameters.AddWithValue("@sname", row("StudentName"))
                    serverCmd.Parameters.AddWithValue("@branch", row("BranchCode"))
                    serverCmd.Parameters.AddWithValue("@date", row("Date"))
                    serverCmd.Parameters.AddWithValue("@status", row("Status"))
                    Dim r As Integer = serverCmd.ExecuteNonQuery()
                    If r > 0 Then
                        sent += 1
                        ' 4. Mark local record as synced
                        Dim upd As New MySqlCommand(
                            "UPDATE attendance SET Synced = 1 WHERE id = @id", cn)
                        upd.Parameters.AddWithValue("@id", row("id"))
                        upd.ExecuteNonQuery()
                    Else
                        skipped += 1
                    End If
                Catch rowEx As Exception
                    skipped += 1
                End Try
            Next
            serverCn.Close()
            MsgBox("Sync complete!" & vbCrLf & "Sent: " & sent & "  Skipped (duplicates): " & skipped,
                   MsgBoxStyle.Information, "Sync Result")
            LoadAttendance()
        Catch ex As Exception
            MsgBox("Sync error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
