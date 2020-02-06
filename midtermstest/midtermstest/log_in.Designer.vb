<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log_in
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
        Me.login_panel = New System.Windows.Forms.Panel()
        Me.login = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.login_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'login_panel
        '
        Me.login_panel.Controls.Add(Me.login)
        Me.login_panel.Controls.Add(Me.pass)
        Me.login_panel.Controls.Add(Me.Label2)
        Me.login_panel.Controls.Add(Me.uname)
        Me.login_panel.Controls.Add(Me.Label1)
        Me.login_panel.Location = New System.Drawing.Point(12, 12)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.Size = New System.Drawing.Size(285, 256)
        Me.login_panel.TabIndex = 0
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(98, 207)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(75, 23)
        Me.login.TabIndex = 3
        Me.login.Text = "Log in"
        Me.login.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(86, 148)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(100, 20)
        Me.pass.TabIndex = 2
        Me.pass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(86, 92)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(100, 20)
        Me.uname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'log_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 280)
        Me.Controls.Add(Me.login_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "log_in"
        Me.Text = "Log In"
        Me.login_panel.ResumeLayout(False)
        Me.login_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents login_panel As Panel
    Friend WithEvents login As Button
    Friend WithEvents pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents uname As TextBox
    Friend WithEvents Label1 As Label
End Class
