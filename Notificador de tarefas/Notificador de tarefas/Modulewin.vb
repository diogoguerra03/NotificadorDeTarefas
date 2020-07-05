Imports System.Data.SqlClient
Module Modulewin
    Public sUserID As Integer = 0
    Public sUserNome As String = ""
    Public sUserNivel As Integer = 0

    Dim aData As Date = Date.Now()
    Public strData As String = aData.ToString("dd-MMM-yyyy")

    Public Function Ligacao() As SqlConnection
        Return New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WinTarefa.mdf;Integrated Security=True")
    End Function

    Public strConexao As SqlConnection = Ligacao()

    Public resultado As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable

    Public Sub Create(ByVal comando As String)
        Try
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = comando

                resultado = cmd.ExecuteNonQuery

                If resultado = 0 Then
                    MessageBox.Show("Falhou a operação de inserir os dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Os dados foram inseridos com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strConexao.Close()
    End Sub

    Public Sub Reload(ByVal Comando As String, Grelha As Object)
        Try
            dt = New DataTable
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = Comando
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Grelha.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strConexao.Close()
        da.Dispose()
    End Sub
    Public Sub Updates(ByVal comando As String)
        Try
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = comando

                resultado = cmd.ExecuteNonQuery

                If resultado = 0 Then
                    MessageBox.Show("Falhou de atualização de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Os dados foram atualizados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strConexao.Close()
    End Sub

    Public Sub Delete(ByVal comando As String)
        Try
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = comando

                resultado = cmd.ExecuteNonQuery

                If resultado = 0 Then
                    MessageBox.Show("Falhou a operação de eliminar os dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Os dados foram eliminados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strConexao.Close()
    End Sub
End Module
