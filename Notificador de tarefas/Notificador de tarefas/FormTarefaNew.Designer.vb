<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTarefaNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTarefaNew))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTarefa = New System.Windows.Forms.TextBox()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.CbDisciplina = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.DtpData = New System.Windows.Forms.DateTimePicker()
        Me.RbSim = New System.Windows.Forms.RadioButton()
        Me.RbNao = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Disciplina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tarefa (titulo):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Data de entrega:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tarefa (descrição):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tarefa (observação):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Estado da entrega:"
        '
        'TxtTarefa
        '
        Me.TxtTarefa.Location = New System.Drawing.Point(210, 103)
        Me.TxtTarefa.Multiline = True
        Me.TxtTarefa.Name = "TxtTarefa"
        Me.TxtTarefa.Size = New System.Drawing.Size(545, 20)
        Me.TxtTarefa.TabIndex = 1
        '
        'TxtObs
        '
        Me.TxtObs.Location = New System.Drawing.Point(210, 438)
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(545, 75)
        Me.TxtObs.TabIndex = 1
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(210, 193)
        Me.TxtDescricao.Multiline = True
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(545, 225)
        Me.TxtDescricao.TabIndex = 1
        '
        'CbDisciplina
        '
        Me.CbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDisciplina.FormattingEnabled = True
        Me.CbDisciplina.Location = New System.Drawing.Point(210, 59)
        Me.CbDisciplina.Name = "CbDisciplina"
        Me.CbDisciplina.Size = New System.Drawing.Size(545, 21)
        Me.CbDisciplina.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFechar)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnCreate)
        Me.GroupBox1.Location = New System.Drawing.Point(772, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 454)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações"
        '
        'BtnFechar
        '
        Me.BtnFechar.Image = Global.Notificador_de_tarefas.My.Resources.Resources.close_icon__1_
        Me.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFechar.Location = New System.Drawing.Point(58, 299)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(80, 60)
        Me.BtnFechar.TabIndex = 0
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Notificador_de_tarefas.My.Resources.Resources.Cross_Folder_icon__2_
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancel.Location = New System.Drawing.Point(58, 184)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 60)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_add_icon
        Me.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCreate.Location = New System.Drawing.Point(58, 72)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(80, 60)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Adicionar"
        Me.BtnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'DtpData
        '
        Me.DtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpData.Location = New System.Drawing.Point(210, 146)
        Me.DtpData.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DtpData.Name = "DtpData"
        Me.DtpData.Size = New System.Drawing.Size(171, 26)
        Me.DtpData.TabIndex = 4
        '
        'RbSim
        '
        Me.RbSim.AutoSize = True
        Me.RbSim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSim.Location = New System.Drawing.Point(590, 146)
        Me.RbSim.Name = "RbSim"
        Me.RbSim.Size = New System.Drawing.Size(54, 24)
        Me.RbSim.TabIndex = 5
        Me.RbSim.TabStop = True
        Me.RbSim.Text = "Sim"
        Me.RbSim.UseVisualStyleBackColor = True
        '
        'RbNao
        '
        Me.RbNao.AutoSize = True
        Me.RbNao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNao.Location = New System.Drawing.Point(682, 146)
        Me.RbNao.Name = "RbNao"
        Me.RbNao.Size = New System.Drawing.Size(56, 24)
        Me.RbNao.TabIndex = 6
        Me.RbNao.TabStop = True
        Me.RbNao.Text = "Não"
        Me.RbNao.UseVisualStyleBackColor = True
        '
        'FormTarefaNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 525)
        Me.Controls.Add(Me.RbNao)
        Me.Controls.Add(Me.RbSim)
        Me.Controls.Add(Me.DtpData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CbDisciplina)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.TxtObs)
        Me.Controls.Add(Me.TxtTarefa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTarefaNew"
        Me.Text = "Registo de uma nova tarefa"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTarefa As TextBox
    Friend WithEvents TxtObs As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents CbDisciplina As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents DtpData As DateTimePicker
    Friend WithEvents RbSim As RadioButton
    Friend WithEvents RbNao As RadioButton
End Class
