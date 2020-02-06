Imports MySql.Data.MySqlClient
Public Class log_in
    'copypaste to work across all nations----------------------------------------
    Dim sql As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Dim dtable As DataTable
    Dim adapter As MySqlDataAdapter
    Dim bind As BindingSource
    Private Sub Command(query As String)
        cmd = New MySqlCommand(query, sql)
    End Sub

    Private Sub Read()
        reader = cmd.ExecuteReader
    End Sub

    Private Sub Uupdate(table As DataGridView)
        adapter = New MySqlDataAdapter
        dtable = New DataTable
        bind = New BindingSource

        adapter.SelectCommand = cmd
        adapter.Fill(dtable)
        bind.DataSource = dtable
        table.DataSource = bind
        adapter.Update(dtable)

    End Sub

    '----------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.ConnectionString =
            "server=localhost;userid=root;password=test;database=midterms"

        'Check if the sql was connected successfully, can be omitted
        Try
            sql.Open()
            MessageBox.Show("opened")
            sql.Close()
        Catch ex As MySqlException
            MessageBox.Show((ex.Message))
        Finally
            sql.Dispose()
        End Try


    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        Try
            sql.Open()
            Command("select * from midterms.log where name='" + uname.Text +
                    "' and pass='" + pass.Text + "'")
            Read()
            Dim count As Integer = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("correct")
                Menu_main.username = uname.Text
                For Each control In login_panel.Controls
                    If TypeOf control Is TextBox Then
                        control.clear()
                    End If
                    Menu_main.Show()
                    Me.Hide()
                Next
            ElseIf count > 1 Then
                MessageBox.Show("duplicate")
            Else
                MessageBox.Show("incorrect")
            End If

            sql.Close()
        Catch ex As MySqlException
            MessageBox.Show((ex.Message))
        Finally
            sql.Dispose()
        End Try
    End Sub
End Class
