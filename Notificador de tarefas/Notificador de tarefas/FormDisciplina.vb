Imports System.Data.SqlClient
Public Class FormDisciplina
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        Try
            'chamar o procedimento Create codificado no modulo ModuleWin
            Create("INSERT INTO disciplina (idProf, disciplina, ano, modulo) VALUES (" & (CbProfessor.SelectedValue) & ",'" & TxtDisciplina.Text & "'," & CInt(CbAno.SelectedItem) & "," & CInt(CbModulo.SelectedItem) & ")")

        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click

        Try

            Reload("SELECT Disciplina.idDisciplina, Disciplina.disciplina, Disciplina.ano, Disciplina.modulo, Professor.nome FROM Professor INNER JOIN Disciplina ON Professor.idProf = Disciplina.idProf", Grelha)
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            'chamar o método Updates codificado no modulo ModuleWin
            Updates("UPDATE disciplina SET disciplina='" & TxtDisciplina.Text & "', " & "idProf=" & CInt(CbProfessor.SelectedValue) &
                    ", " & "ano=" & CInt(CbAno.SelectedItem) & ", " & "modulo=" & CInt(CbModulo.SelectedItem) & " WHERE idDisciplina=" & CInt(LblID.Text))

        Catch ex As Exception
            MessageBox.Show("ERROf: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            'chamar o método Delete codificado no modulo ModuleWin
            Delete("DELETE FROM disciplina WHERE idDisciplina=" & CInt(LblID.Text))
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Grelha_DoubleClick(sender As Object, e As EventArgs) Handles Grelha.DoubleClick
        LblID.Text = Grelha.CurrentRow.Cells(0).Value
        TxtDisciplina.Text = Grelha.CurrentRow.Cells(1).Value
        CbAno.Text = Grelha.CurrentRow.Cells(2).Value
        CbModulo.Text = Grelha.CurrentRow.Cells(3).Value
        CbProfessor.Text = Grelha.CurrentRow.Cells(4).Value

        Me.Grelha.Columns(0).Width = 0
        Me.Grelha.Columns("disciplina").Width = 250
        Me.Grelha.Columns("ano").Width = 75
        Me.Grelha.Columns("modulo").Width = 75
        Me.Grelha.Columns("nome").Width = 150
    End Sub

    Private Sub FormDisciplina_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            strConexao.Open()
            Dim comando As New SqlCommand("SELECT * FROM professor ORDER BY idProf ASC", strConexao)
            Dim daCombo As New SqlDataAdapter(comando)
            Dim dtCombo As New DataTable()
            daCombo.Fill(dtCombo)
            CbProfessor.DataSource = dtCombo
            CbProfessor.DisplayMember = "nome"
            CbProfessor.ValueMember = "idProf"
            CbProfessor.SelectedIndex = -1
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        strConexao.Close()
        'mandar executar o botão
        Me.BtnReload.PerformClick()
        'colocar o foco do cursor
        TxtDisciplina.Select()
        'ocultar label com o ID
        LblID.Visible = False
        'redimensionar as colunas
        Me.Grelha.Columns(0).Width = 0
        Me.Grelha.Columns("disciplina").Width = 250
        Me.Grelha.Columns("ano").Width = 80
        Me.Grelha.Columns("modulo").Width = 80
        Me.Grelha.Columns("nome").Width = 150
    End Sub

End Class