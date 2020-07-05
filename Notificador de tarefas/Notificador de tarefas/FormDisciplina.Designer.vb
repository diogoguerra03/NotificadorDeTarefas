<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDisciplina
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDisciplina))
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblProfessor = New System.Windows.Forms.Label()
        Me.LblDisciplina = New System.Windows.Forms.Label()
        Me.LblAno = New System.Windows.Forms.Label()
        Me.LblNrMod = New System.Windows.Forms.Label()
        Me.CbModulo = New System.Windows.Forms.ComboBox()
        Me.CbAno = New System.Windows.Forms.ComboBox()
        Me.CbProfessor = New System.Windows.Forms.ComboBox()
        Me.TxtDisciplina = New System.Windows.Forms.TextBox()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnReload
        '
        Me.BtnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReload.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_info_icon
        Me.BtnReload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReload.Location = New System.Drawing.Point(658, 72)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(85, 62)
        Me.BtnReload.TabIndex = 4
        Me.BtnReload.Text = "Atualizar"
        Me.BtnReload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_delete_icon
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDelete.Location = New System.Drawing.Point(658, 140)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 62)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Apagar"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_edit_icon
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUpdate.Location = New System.Drawing.Point(567, 139)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 62)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "Editar"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Image = Global.Notificador_de_tarefas.My.Resources.Resources.File_add_icon
        Me.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCreate.Location = New System.Drawing.Point(567, 72)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(85, 62)
        Me.BtnCreate.TabIndex = 7
        Me.BtnCreate.Text = "Criar"
        Me.BtnCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(37, 48)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(26, 20)
        Me.LblID.TabIndex = 8
        Me.LblID.Text = "ID"
        '
        'LblProfessor
        '
        Me.LblProfessor.AutoSize = True
        Me.LblProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfessor.Location = New System.Drawing.Point(37, 77)
        Me.LblProfessor.Name = "LblProfessor"
        Me.LblProfessor.Size = New System.Drawing.Size(77, 20)
        Me.LblProfessor.TabIndex = 8
        Me.LblProfessor.Text = "Professor"
        '
        'LblDisciplina
        '
        Me.LblDisciplina.AutoSize = True
        Me.LblDisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisciplina.Location = New System.Drawing.Point(37, 119)
        Me.LblDisciplina.Name = "LblDisciplina"
        Me.LblDisciplina.Size = New System.Drawing.Size(76, 20)
        Me.LblDisciplina.TabIndex = 8
        Me.LblDisciplina.Text = "Disciplina"
        '
        'LblAno
        '
        Me.LblAno.AutoSize = True
        Me.LblAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAno.Location = New System.Drawing.Point(37, 172)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(75, 20)
        Me.LblAno.TabIndex = 8
        Me.LblAno.Text = "Ano/Nivel"
        '
        'LblNrMod
        '
        Me.LblNrMod.AutoSize = True
        Me.LblNrMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNrMod.Location = New System.Drawing.Point(308, 172)
        Me.LblNrMod.Name = "LblNrMod"
        Me.LblNrMod.Size = New System.Drawing.Size(107, 20)
        Me.LblNrMod.TabIndex = 8
        Me.LblNrMod.Text = "Nr. de Modulo"
        '
        'CbModulo
        '
        Me.CbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbModulo.FormattingEnabled = True
        Me.CbModulo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19"})
        Me.CbModulo.Location = New System.Drawing.Point(421, 169)
        Me.CbModulo.Name = "CbModulo"
        Me.CbModulo.Size = New System.Drawing.Size(121, 28)
        Me.CbModulo.TabIndex = 9
        '
        'CbAno
        '
        Me.CbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAno.FormattingEnabled = True
        Me.CbAno.Items.AddRange(New Object() {"10", "11", "12"})
        Me.CbAno.Location = New System.Drawing.Point(125, 169)
        Me.CbAno.Name = "CbAno"
        Me.CbAno.Size = New System.Drawing.Size(121, 28)
        Me.CbAno.TabIndex = 10
        '
        'CbProfessor
        '
        Me.CbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProfessor.FormattingEnabled = True
        Me.CbProfessor.Location = New System.Drawing.Point(125, 74)
        Me.CbProfessor.Name = "CbProfessor"
        Me.CbProfessor.Size = New System.Drawing.Size(417, 28)
        Me.CbProfessor.TabIndex = 11
        '
        'TxtDisciplina
        '
        Me.TxtDisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisciplina.Location = New System.Drawing.Point(125, 119)
        Me.TxtDisciplina.Name = "TxtDisciplina"
        Me.TxtDisciplina.Size = New System.Drawing.Size(417, 26)
        Me.TxtDisciplina.TabIndex = 12
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.AllowUserToDeleteRows = False
        Me.Grelha.AllowUserToResizeColumns = False
        Me.Grelha.AllowUserToResizeRows = False
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grelha.Location = New System.Drawing.Point(12, 208)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grelha.Size = New System.Drawing.Size(741, 230)
        Me.Grelha.TabIndex = 13
        '
        'FormDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 450)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.TxtDisciplina)
        Me.Controls.Add(Me.CbProfessor)
        Me.Controls.Add(Me.CbAno)
        Me.Controls.Add(Me.CbModulo)
        Me.Controls.Add(Me.LblNrMod)
        Me.Controls.Add(Me.LblAno)
        Me.Controls.Add(Me.LblDisciplina)
        Me.Controls.Add(Me.LblProfessor)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDisciplina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDisciplina"
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents WinTarefaDataSet As WinTarefaDataSet
    Friend WithEvents DisciplinaBindingSource As BindingSource
    Friend WithEvents DisciplinaTableAdapter As WinTarefaDataSetTableAdapters.DisciplinaTableAdapter
    Friend WithEvents TableAdapterManager As WinTarefaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LblID As Label
    Friend WithEvents LblProfessor As Label
    Friend WithEvents LblDisciplina As Label
    Friend WithEvents LblAno As Label
    Friend WithEvents LblNrMod As Label
    Friend WithEvents CbModulo As ComboBox
    Friend WithEvents CbAno As ComboBox
    Friend WithEvents CbProfessor As ComboBox
    Friend WithEvents TxtDisciplina As TextBox
    Friend WithEvents Grelha As DataGridView
End Class
