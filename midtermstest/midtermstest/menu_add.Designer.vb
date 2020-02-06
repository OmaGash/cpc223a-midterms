<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_add
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.race = New System.Windows.Forms.TextBox()
        Me.main_menu = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'nname
        '
        Me.nname.Location = New System.Drawing.Point(48, 14)
        Me.nname.Name = "nname"
        Me.nname.Size = New System.Drawing.Size(100, 20)
        Me.nname.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.race)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.age)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.gender)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.nname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 137)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gender"
        '
        'gender
        '
        Me.gender.Location = New System.Drawing.Point(48, 40)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(100, 20)
        Me.gender.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Age"
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(48, 66)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(100, 20)
        Me.age.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Race"
        '
        'race
        '
        Me.race.Location = New System.Drawing.Point(48, 92)
        Me.race.Name = "race"
        Me.race.Size = New System.Drawing.Size(100, 20)
        Me.race.TabIndex = 1
        '
        'main_menu
        '
        Me.main_menu.Location = New System.Drawing.Point(12, 155)
        Me.main_menu.Name = "main_menu"
        Me.main_menu.Size = New System.Drawing.Size(75, 23)
        Me.main_menu.TabIndex = 3
        Me.main_menu.Text = "Main Menu"
        Me.main_menu.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(99, 155)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'menu_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 192)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.main_menu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "menu_add"
        Me.Text = "menu_add"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents race As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gender As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents main_menu As Button
    Friend WithEvents btn_add As Button
End Class
