<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTarefaList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTarefaList))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.Grelha = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFechar)
        Me.GroupBox1.Location = New System.Drawing.Point(788, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 344)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações"
        '
        'BtnFechar
        '
        Me.BtnFechar.Image = Global.Notificador_de_tarefas.My.Resources.Resources.close_icon__1_
        Me.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFechar.Location = New System.Drawing.Point(27, 144)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(80, 60)
        Me.BtnFechar.TabIndex = 0
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'Grelha
        '
        Me.Grelha.AllowUserToAddRows = False
        Me.Grelha.AllowUserToDeleteRows = False
        Me.Grelha.AllowUserToResizeColumns = False
        Me.Grelha.AllowUserToResizeRows = False
        Me.Grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grelha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grelha.Location = New System.Drawing.Point(12, 12)
        Me.Grelha.Name = "Grelha"
        Me.Grelha.RowHeadersVisible = False
        Me.Grelha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grelha.Size = New System.Drawing.Size(741, 513)
        Me.Grelha.TabIndex = 14
        '
        'FormTarefaList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 537)
        Me.Controls.Add(Me.Grelha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTarefaList"
        Me.Text = "FormTarefaList"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grelha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFechar As Button
    Friend WithEvents Grelha As DataGridView
End Class
