Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisciplinasToolStripMenuItem.Enabled = False
        ProfessoresToolStripMenuItem.Enabled = False
        InserirNovaTarefaToolStripMenuItem.Enabled = False
        ListagemDasTarefasToolStripMenuItem.Enabled = False
        If sUserNivel = 0 Then
            UserToolStripMenuItem.Visible = False
        Else
            UserToolStripMenuItem.Visible = True
            DisciplinasToolStripMenuItem.Enabled = True
            ProfessoresToolStripMenuItem.Enabled = True
            InserirNovaTarefaToolStripMenuItem.Enabled = True
            ListagemDasTarefasToolStripMenuItem.Enabled = True
        End If
        tslabelData.Text = strData

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "Notificador de tarefas v1.0"
        NotifyIcon1.BalloonTipTitle = "Esta é uma mensagem de notificação"
        NotifyIcon1.ShowBalloonTip(2000)

        Dim f As New LoginForm1
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        MessageBox.Show("Aqui aparece a notificação da tarefa.")
        NotifyIcon1.Visible = False
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ProfessoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessoresToolStripMenuItem.Click
        Dim f As New FormProfessor
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub DisciplinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinasToolStripMenuItem.Click
        Dim j As New FormDisciplina
        j.MdiParent = Me
        j.Show()
    End Sub

    Private Sub InserirNovaTarefaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserirNovaTarefaToolStripMenuItem.Click
        Dim f As New FormTarefaNew
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ListagemDasTarefasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDasTarefasToolStripMenuItem.Click
        Dim f As New FormTarefaList
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
