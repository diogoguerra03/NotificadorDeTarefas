<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarefaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirNovaTarefaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefiniçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisciplinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfessoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OMeuPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslabelData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ListagemDasTarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem, Me.TarefaToolStripMenuItem, Me.DefiniçõesToolStripMenuItem, Me.UserToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1424, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(77, 25)
        Me.FicheiroToolStripMenuItem.Text = "&Ficheiro"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(107, 26)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'TarefaToolStripMenuItem
        '
        Me.TarefaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirNovaTarefaToolStripMenuItem, Me.ListagemDasTarefasToolStripMenuItem})
        Me.TarefaToolStripMenuItem.Name = "TarefaToolStripMenuItem"
        Me.TarefaToolStripMenuItem.Size = New System.Drawing.Size(70, 25)
        Me.TarefaToolStripMenuItem.Text = "&Tarefas"
        '
        'InserirNovaTarefaToolStripMenuItem
        '
        Me.InserirNovaTarefaToolStripMenuItem.Name = "InserirNovaTarefaToolStripMenuItem"
        Me.InserirNovaTarefaToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.InserirNovaTarefaToolStripMenuItem.Text = "Inserir &nova tarefa"
        '
        'DefiniçõesToolStripMenuItem
        '
        Me.DefiniçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisciplinasToolStripMenuItem, Me.ProfessoresToolStripMenuItem})
        Me.DefiniçõesToolStripMenuItem.Name = "DefiniçõesToolStripMenuItem"
        Me.DefiniçõesToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.DefiniçõesToolStripMenuItem.Text = "Definições"
        '
        'DisciplinasToolStripMenuItem
        '
        Me.DisciplinasToolStripMenuItem.Name = "DisciplinasToolStripMenuItem"
        Me.DisciplinasToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.DisciplinasToolStripMenuItem.Text = "Disciplinas"
        '
        'ProfessoresToolStripMenuItem
        '
        Me.ProfessoresToolStripMenuItem.Name = "ProfessoresToolStripMenuItem"
        Me.ProfessoresToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.ProfessoresToolStripMenuItem.Text = "Professores"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OMeuPerfilToolStripMenuItem, Me.TerminarSessãoToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(52, 25)
        Me.UserToolStripMenuItem.Text = "user"
        '
        'OMeuPerfilToolStripMenuItem
        '
        Me.OMeuPerfilToolStripMenuItem.Name = "OMeuPerfilToolStripMenuItem"
        Me.OMeuPerfilToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.OMeuPerfilToolStripMenuItem.Text = "O meu Perfil"
        '
        'TerminarSessãoToolStripMenuItem
        '
        Me.TerminarSessãoToolStripMenuItem.Name = "TerminarSessãoToolStripMenuItem"
        Me.TerminarSessãoToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.TerminarSessãoToolStripMenuItem.Text = "Terminar sessão"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.SobreToolStripMenuItem.Text = "Sobre..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslabelData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1424, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslabelData
        '
        Me.tslabelData.Name = "tslabelData"
        Me.tslabelData.Size = New System.Drawing.Size(59, 17)
        Me.tslabelData.Text = "data atual"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ListagemDasTarefasToolStripMenuItem
        '
        Me.ListagemDasTarefasToolStripMenuItem.Name = "ListagemDasTarefasToolStripMenuItem"
        Me.ListagemDasTarefasToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.ListagemDasTarefasToolStripMenuItem.Text = "&Listagem das tarefas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 661)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificador de tarefas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents tslabelData As ToolStripStatusLabel
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OMeuPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefiniçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisciplinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfessoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarefaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InserirNovaTarefaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListagemDasTarefasToolStripMenuItem As ToolStripMenuItem
End Class
