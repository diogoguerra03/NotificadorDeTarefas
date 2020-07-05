Public Class FormProfessor
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        Try
            Create("INSERT INTO professor (nome, email, salavirtual, telefone) VALUES ('" & TxtNome.Text & "','" & TxtEmail.Text & "','" & TxtSala.Text & "'," & CInt(TxtTelefone.Text) & ")")
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO" & ex.Message,
            "Erro!", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click

        Try

            Reload("SELECT * FROM professor ORDER BY idProf ASC", Grelha)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message,
            "Erro!", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Try
            Updates("UPDATE professor SET nome='" & TxtNome.Text & "', " & "email='" & TxtEmail.Text & "', " & "salavirtual='" & TxtSala.Text & "', " & "telefone=" & CInt(TxtTelefone.Text) & " WHERE idProf=" & CInt(LblID.Text))
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO" & ex.Message,
            "Erro!", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Try

            Delete("DELETE FROM professor WHERE idProf=" & CInt(LblID.Text))
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO" & ex.Message,
            "Erro!", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Grelha_DoubleClick(sender As Object, e As EventArgs) Handles Grelha.DoubleClick

        LblID.Text = Grelha.CurrentRow.Cells(0).Value
        TxtNome.Text = Grelha.CurrentRow.Cells(1).Value
        TxtEmail.Text = Grelha.CurrentRow.Cells(2).Value
        TxtSala.Text = Grelha.CurrentRow.Cells(3).Value
        TxtTelefone.Text = Grelha.CurrentRow.Cells(4).Value

        Me.Grelha.Columns(0).Width = 0
        Me.Grelha.Columns("nome").Width = 175
        Me.Grelha.Columns("email").Width = 235
        Me.Grelha.Columns("salavirtual").Width = 235
        Me.Grelha.Columns("telefone").Width = 75

    End Sub

    Private Sub FormProfessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BtnReload.PerformClick()

        TxtNome.Select()
        LblID.Visible = False
        Me.Grelha.Columns(0).Width = 0
        Me.Grelha.Columns("nome").Width = 175
        Me.Grelha.Columns("email").Width = 235
        Me.Grelha.Columns("salavirtual").Width = 235
        Me.Grelha.Columns("telefone").Width = 85
    End Sub

End Class