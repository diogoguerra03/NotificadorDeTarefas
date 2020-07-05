Imports System.Data.SqlClient
Public Class FormTarefaNew
    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        'encerrar o form
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        'limpeza de dados os controlos
        CbDisciplina.SelectedIndex = -1
        TxtTarefa.ResetText()
        DtpData.Value = Now
        RbNao.Checked = False
        RbSim.Checked = False
        TxtDescricao.ResetText()
        TxtObs.ResetText()
    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            'chamar o procedimento Create codificado no modulo ModuleWin
            'e colocar a query no parametro para inserir os dados.
            Dim xestado As Integer = 0
            If RbSim.Checked = True Then
                xestado = 1
            End If
            Create("INSERT INTO tarefa (idDisciplina, tarefa, descricao, data, estado, obs) VALUES (" & CbDisciplina.SelectedValue & ",'" &
                   TxtTarefa.Text & "','" & TxtDescricao.Text & "','" & (DtpData.Value) & "'," & xestado & ",'" & TxtObs.Text & "')")

        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message,
            "Erro!", MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try
        'limpar dados do form para evitar duplicação de registos
        BtnCancel.PerformClick()
    End Sub

    Private Sub FormTarefaNew_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            strConexao.Open()
            Dim comando As New SqlCommand("SELECT * FROM disciplina ORDER BY idDisciplina ASC", strConexao)
            Dim daCombo As New SqlDataAdapter(comando)
            Dim dtCombo As New DataTable()
            daCombo.Fill(dtCombo)
            CbDisciplina.DataSource = dtCombo
            CbDisciplina.DisplayMember = "disciplina"
            CbDisciplina.ValueMember = "idDisciplina"
            CbDisciplina.SelectedIndex = -1
        Catch ex As Exception
            'em caso de erro exibir o mesmo
            MessageBox.Show("ERRO: " & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strConexao.Close()
    End Sub
End Class
