Imports MySql.Data.MySqlClient

Module dbConnector
    Public cn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub Connect()
        Try
            cn.Close()
            cn.ConnectionString = "server=localhost;user=root;password=;database=attendance_branch_a_db"
            cn.Open()
        Catch ex As Exception
            MsgBox("DB Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module