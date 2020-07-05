Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm1
    Dim tentativa As Integer = 1
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtlogin.Select()

    End Sub


    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Wintarefa.mdf;
                                    Integrated Security=True;Connect Timeout=30"

        Dim ligacao As SqlConnection = New SqlConnection(connString)

        Try
            ligacao.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Aluno WHERE login = '" &
                                               txtlogin.Text & "' AND senha = '" & txtsenha.Text & "'", ligacao)

        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim encontrou As Boolean = False

        If dr.HasRows Then
            While dr.Read
                encontrou = True
                sUserNome = dr("nome").ToString
                sUserID = dr("idUser")
                sUserNivel = 1
            End While
        End If

        ligacao.Close()

        If tentativa <> 3 Then
            If encontrou = True Then
                Me.Close()
                MessageBox.Show("Bem vindo(a) " & sUserNome & "." & vbNewLine + "Autenticado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.UserToolStripMenuItem.Text = sUserNome
                Form1.UserToolStripMenuItem.Visible = True
                Form1.ProfessoresToolStripMenuItem.Enabled = True
                Form1.DisciplinasToolStripMenuItem.Enabled = True
                Form1.InserirNovaTarefaToolStripMenuItem.Enabled = True
                Form1.ListagemDasTarefasToolStripMenuItem.Enabled = True
                Form1.Refresh()
            Else

                tentativa += 1
                Dim msg As String = "Não encontrado." & vbNewLine & "Utilizador ou senha incorretos."
                Dim titulo As String = "Aviso!"
                Dim botoes = MessageBoxButtons.OK
                Dim icone = MessageBoxIcon.Exclamation
                MessageBox.Show(msg, titulo, botoes, icone)
                txtlogin.Text = ""
                txtsenha.Text = ""
            End If
        Else
            Dim msg As String = "Não encontrado." & vbNewLine & "Utilizador ou senha incorretos." & vbNewLine & "A aplicação vai ser encerrada."
            Dim titulo As String = "Aviso!"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Exclamation
            MessageBox.Show(msg, titulo, botoes, icone)
            Application.Exit()
        End If

    End Sub
End Class
