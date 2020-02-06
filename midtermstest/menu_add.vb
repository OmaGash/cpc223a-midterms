Imports MySql.Data.MySqlClient
Public Class Menu_add
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
    Private Sub Menu_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.ConnectionString = "server=localhost;userid=root;password=test;database=midterms"

        Try
            sql.Open()
            MessageBox.Show("asd")
            sql.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            sql.Dispose()
        End Try
    End Sub
End Class