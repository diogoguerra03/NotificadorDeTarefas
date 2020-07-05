Public Class FormTarefaList
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub
    Private Sub FormTarefaList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'chamar o método Reload codificado no modulo ModuleWin
            Reload("SELECT * FROM tarefa ORDER BY idDisciplina ASC", Grelha)
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class