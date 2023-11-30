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
        components = New ComponentModel.Container()
        leftPanel = New Panel()
        leftPanelMS = New ContextMenuStrip(components)
        NovoToolStripMenuItem = New ToolStripMenuItem()
        ListaToolStripMenuItem = New ToolStripMenuItem()
        leftPanelMS.SuspendLayout()
        SuspendLayout()
        ' 
        ' leftPanel
        ' 
        leftPanel.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        leftPanel.ContextMenuStrip = leftPanelMS
        leftPanel.Dock = DockStyle.Left
        leftPanel.Location = New Point(0, 0)
        leftPanel.Name = "leftPanel"
        leftPanel.Size = New Size(164, 531)
        leftPanel.TabIndex = 0
        ' 
        ' leftPanelMS
        ' 
        leftPanelMS.Items.AddRange(New ToolStripItem() {NovoToolStripMenuItem})
        leftPanelMS.Name = "left_panel_ms"
        leftPanelMS.Size = New Size(104, 26)
        ' 
        ' NovoToolStripMenuItem
        ' 
        NovoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListaToolStripMenuItem})
        NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        NovoToolStripMenuItem.Size = New Size(103, 22)
        NovoToolStripMenuItem.Text = "Novo"
        ' 
        ' ListaToolStripMenuItem
        ' 
        ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        ListaToolStripMenuItem.Size = New Size(98, 22)
        ListaToolStripMenuItem.Text = "Lista"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        ClientSize = New Size(757, 531)
        Controls.Add(leftPanel)
        Name = "Form1"
        Text = "Todo"
        leftPanelMS.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents leftPanel As Panel
    Friend WithEvents leftPanelMS As ContextMenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
End Class
