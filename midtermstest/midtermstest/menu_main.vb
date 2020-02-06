Imports MySql.Data.MySqlClient
Public Class Menu_main
    Dim search_mode As String
    Public username As String
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
    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.ConnectionString = "server=localhost;userid=root;password=test;database=midterms"
        welcome.Text = "Welcome, " + username
        Try
            sql.Open()
            Command("select * from midterms.info")
            Uupdate(table)
            sql.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            sql.Dispose()
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Menu_add.Show()
        Me.Hide()
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Try
            sql.Open()
            Command("select * from midterms.info where`" + search_mode + "` like '" + searchbox.Text + "%'")

            Uupdate(table)
            sql.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sql.Dispose()
        End Try
    End Sub

    Private Sub selection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selection.SelectedIndexChanged
        searchbox.Enabled = True
        MessageBox.Show(selection.SelectedIndex.ToString)
        Select Case selection.SelectedIndex
            Case 0
                search_mode = "id"
            Case 1
                search_mode = "name"
            Case 2
                search_mode = "gender"
            Case 3
                search_mode = "age"
            Case 4
                search_mode = "race"
        End Select

    End Sub

    Private Sub select_all_Click(sender As Object, e As EventArgs) Handles select_all.Click
        table.SelectAll()
    End Sub

    Private Sub select_none_Click(sender As Object, e As EventArgs) Handles select_none.Click
        table.ClearSelection()
    End Sub

    Private Sub delete_select_Click(sender As Object, e As EventArgs) Handles delete_select.Click
        If Not table.SelectedRows.Count = 0 Then
            MessageBox.Show(table.SelectedRows(0).Cells(0).Value.ToString)
            Try
                sql.Open()
                Command("delete from midterms.info where id = " + table.SelectedRows(0).Cells(0).Value.ToString + "")
                Uupdate(table)
                Command("select * from midterms.info")
                Uupdate(table)
                sql.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                sql.Dispose()
            End Try
        Else
            MessageBox.Show("No row selected.")
        End If
    End Sub

    Private Sub delete_id_Click(sender As Object, e As EventArgs) Handles delete_id.Click
        Dim choice As String = InputBox("Enter ID:", "Delete via ID")
        Try
            sql.Open()
            Command("delete from midterms.info where id = " + choice +
                    ";select * from midterms.info")
            Uupdate(table)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sql.Dispose()
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            sql.Open()
            Dim newdtable As DataTable = dtable.GetChanges
            If newdtable.IsInitialized Then
                Dim cmdbuilder As MySqlCommandBuilder
                cmdbuilder = New MySqlCommandBuilder(adapter)
                'MessageBox.Show("horaah")
                adapter.Update(newdtable)
                MessageBox.Show("Updated successfully")
            End If
            sql.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sql.Dispose()

        End Try
    End Sub
End Class