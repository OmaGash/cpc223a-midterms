<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.table = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.delete_select = New System.Windows.Forms.Button()
        Me.delete_id = New System.Windows.Forms.Button()
        Me.select_all = New System.Windows.Forms.Button()
        Me.select_none = New System.Windows.Forms.Button()
        Me.log_out = New System.Windows.Forms.Button()
        Me.welcome = New System.Windows.Forms.Label()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.selection = New System.Windows.Forms.ComboBox()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'table
        '
        Me.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.table.Location = New System.Drawing.Point(12, 79)
        Me.table.MultiSelect = False
        Me.table.Name = "table"
        Me.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.table.Size = New System.Drawing.Size(501, 188)
        Me.table.TabIndex = 0
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(12, 273)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'delete_select
        '
        Me.delete_select.Location = New System.Drawing.Point(93, 273)
        Me.delete_select.Name = "delete_select"
        Me.delete_select.Size = New System.Drawing.Size(100, 23)
        Me.delete_select.TabIndex = 1
        Me.delete_select.Text = "Delete (Selection)"
        Me.delete_select.UseVisualStyleBackColor = True
        '
        'delete_id
        '
        Me.delete_id.Location = New System.Drawing.Point(199, 273)
        Me.delete_id.Name = "delete_id"
        Me.delete_id.Size = New System.Drawing.Size(75, 23)
        Me.delete_id.TabIndex = 1
        Me.delete_id.Text = "Delete (ID)"
        Me.delete_id.UseVisualStyleBackColor = True
        '
        'select_all
        '
        Me.select_all.Location = New System.Drawing.Point(332, 10)
        Me.select_all.Name = "select_all"
        Me.select_all.Size = New System.Drawing.Size(75, 23)
        Me.select_all.TabIndex = 1
        Me.select_all.Text = "Select All"
        Me.select_all.UseVisualStyleBackColor = True
        '
        'select_none
        '
        Me.select_none.Location = New System.Drawing.Point(413, 10)
        Me.select_none.Name = "select_none"
        Me.select_none.Size = New System.Drawing.Size(75, 23)
        Me.select_none.TabIndex = 1
        Me.select_none.Text = "Select None"
        Me.select_none.UseVisualStyleBackColor = True
        '
        'log_out
        '
        Me.log_out.Location = New System.Drawing.Point(438, 273)
        Me.log_out.Name = "log_out"
        Me.log_out.Size = New System.Drawing.Size(75, 23)
        Me.log_out.TabIndex = 1
        Me.log_out.Text = "Log Out"
        Me.log_out.UseVisualStyleBackColor = True
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Location = New System.Drawing.Point(12, 13)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(82, 13)
        Me.welcome.TabIndex = 2
        Me.welcome.Text = "placeholder text"
        '
        'searchbox
        '
        Me.searchbox.Enabled = False
        Me.searchbox.Location = New System.Drawing.Point(184, 10)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(121, 20)
        Me.searchbox.TabIndex = 3
        Me.searchbox.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.selection)
        Me.Panel1.Controls.Add(Me.searchbox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.select_all)
        Me.Panel1.Controls.Add(Me.select_none)
        Me.Panel1.Location = New System.Drawing.Point(15, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 44)
        Me.Panel1.TabIndex = 4
        '
        'selection
        '
        Me.selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selection.FormattingEnabled = True
        Me.selection.Items.AddRange(New Object() {"ID", "Name", "Gender", "Age", "Race"})
        Me.selection.Location = New System.Drawing.Point(53, 10)
        Me.selection.Name = "selection"
        Me.selection.Size = New System.Drawing.Size(121, 21)
        Me.selection.TabIndex = 4
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(280, 272)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Menu_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 307)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.delete_id)
        Me.Controls.Add(Me.delete_select)
        Me.Controls.Add(Me.log_out)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Menu_main"
        Me.Text = "menu"
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents table As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents delete_select As Button
    Friend WithEvents delete_id As Button
    Friend WithEvents select_all As Button
    Friend WithEvents select_none As Button
    Friend WithEvents log_out As Button
    Friend WithEvents welcome As Label
    Friend WithEvents searchbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents selection As ComboBox
    Friend WithEvents btn_update As Button
End Class
