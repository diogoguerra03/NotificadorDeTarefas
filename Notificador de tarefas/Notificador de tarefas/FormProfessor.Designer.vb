<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfessor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfessor))
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.Lblsala = New System.Windows.Forms.Label()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtSala = New System.Windows.Forms.TextBox()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(29, 22)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(26, 20)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "ID"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome.Location = New System.Drawing.Point(29, 74)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(51, 20)
        Me.LblNome.TabIndex = 0
        Me.LblNome.Text = "Nome"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(29, 126)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(48, 20)
        Me.LblEmail.TabIndex = 0
        Me.LblEmail.Text = "Email"
        '
        'Lblsala
        '
        Me.Lblsala.AutoSize = True
        Me.Lblsala.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsala.Location = New System.Drawing.Point(29, 178)
        Me.Lblsala.Name = "Lblsala"
        Me.Lblsala.Size = New System.Drawing.Size(90, 20)
        Me.Lblsala.TabIndex = 0
        Me.Lblsala.Text = "Sala Virtual"
        '
        'LblTelefone
        '
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefone.Location = New System.Drawing.Point(29, 230)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(71, 20)
        Me.LblTelefone.TabIndex = 0
        Me.LblTelefone.Text = "Telefone"
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(129, 74)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(400, 26)
        Me.TxtNome.TabIndex = 1
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(129, 126)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(400, 26)
        Me.TxtEmail.TabIndex = 1
        '
        'TxtSala
        '
        Me.TxtSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSala.Location = New System.Drawing.Point(129, 178)
        Me.TxtSala.Name = "TxtSala"
        Me.TxtSala.Size = New System.Drawing.Size(400, 26)
        Me.TxtSala.TabIndex = 1
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefone.Location = New System.Drawing.Point(129, 230)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(400, 26)
        Me.TxtTelefone.TabIndex = 1
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.AllowUserToDeleteRows = False
        Me.Grelha.AllowUserToResizeColumns = False
        Me.Grelha.AllowUserToResizeRows = False
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grelha.Location = New System.Drawing.Point(12, 288)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grelha.Size = New System.Drawing.Size(741, 230)
        Me.Grelha.TabIndex = 2
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_add_icon
        Me.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCreate.Location = New System.Drawing.Point(560, 107)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(85, 62)
        Me.BtnCreate.TabIndex = 3
        Me.BtnCreate.Text = "Criar"
        Me.BtnCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_edit_icon
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUpdate.Location = New System.Drawing.Point(560, 194)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 62)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Editar"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_delete_icon
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDelete.Location = New System.Drawing.Point(667, 194)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 62)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Apagar"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReload.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_info_icon
        Me.BtnReload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReload.Location = New System.Drawing.Point(667, 107)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(85, 62)
        Me.BtnReload.TabIndex = 3
        Me.BtnReload.Text = "Atualizar"
        Me.BtnReload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'FormProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 530)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.TxtTelefone)
        Me.Controls.Add(Me.TxtSala)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblTelefone)
        Me.Controls.Add(Me.Lblsala)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.LblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProfessor"
        Me.Text = "FormProfessor"
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents Lblsala As Label
    Friend WithEvents LblTelefone As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtSala As TextBox
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents Grelha As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnReload As Button
End Class
