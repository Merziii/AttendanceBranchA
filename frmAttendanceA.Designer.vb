<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendanceA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.dgvAttendance = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSync = New System.Windows.Forms.Button()
        Me.btnViewUnsynced = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(37, 43)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(114, 24)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(202, 40)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(267, 31)
        Me.txtStudentID.TabIndex = 1
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(202, 96)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(267, 31)
        Me.txtStudentName.TabIndex = 3
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(37, 99)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(145, 24)
        Me.lblStudentName.TabIndex = 2
        Me.lblStudentName.Text = "Student Name"
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.Location = New System.Drawing.Point(37, 157)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(70, 24)
        Me.lblStatus1.TabIndex = 4
        Me.lblStatus1.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(202, 158)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(267, 28)
        Me.cboStatus.TabIndex = 5
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(675, 62)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(267, 31)
        Me.txtDate.TabIndex = 7
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(550, 65)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 24)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date"
        '
        'txtBranch
        '
        Me.txtBranch.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.Location = New System.Drawing.Point(675, 118)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.ReadOnly = True
        Me.txtBranch.Size = New System.Drawing.Size(267, 31)
        Me.txtBranch.TabIndex = 9
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranch.Location = New System.Drawing.Point(550, 121)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(76, 24)
        Me.lblBranch.TabIndex = 8
        Me.lblBranch.Text = "Branch"
        '
        'dgvAttendance
        '
        Me.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttendance.Location = New System.Drawing.Point(47, 27)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.ReadOnly = True
        Me.dgvAttendance.Size = New System.Drawing.Size(934, 280)
        Me.dgvAttendance.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!)
        Me.btnSave.Location = New System.Drawing.Point(47, 338)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(199, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Attendance"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSync
        '
        Me.btnSync.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!)
        Me.btnSync.Location = New System.Drawing.Point(769, 338)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(199, 35)
        Me.btnSync.TabIndex = 12
        Me.btnSync.Text = "SYNC to Server"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'btnViewUnsynced
        '
        Me.btnViewUnsynced.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!)
        Me.btnViewUnsynced.Location = New System.Drawing.Point(291, 338)
        Me.btnViewUnsynced.Name = "btnViewUnsynced"
        Me.btnViewUnsynced.Size = New System.Drawing.Size(248, 35)
        Me.btnViewUnsynced.TabIndex = 13
        Me.btnViewUnsynced.Text = "View Unsynced Records"
        Me.btnViewUnsynced.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(497, 410)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(17, 24)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.btnViewUnsynced)
        Me.Panel1.Controls.Add(Me.btnSync)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.dgvAttendance)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 458)
        Me.Panel1.TabIndex = 15
        '
        'frmAttendanceA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 671)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.lblStudentID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAttendanceA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch A"
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents lblBranch As Label
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSync As Button
    Friend WithEvents btnViewUnsynced As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Panel1 As Panel
End Class
