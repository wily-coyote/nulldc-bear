<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuddy
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
        Me.tableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.buddyList = New System.Windows.Forms.ListView()
        Me.IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nickname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.buddyActions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tableLayout.SuspendLayout()
        Me.buddyActions.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayout
        '
        Me.tableLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableLayout.ColumnCount = 1
        Me.tableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayout.Controls.Add(Me.buddyList, 0, 0)
        Me.tableLayout.Location = New System.Drawing.Point(0, 24)
        Me.tableLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayout.Name = "tableLayout"
        Me.tableLayout.RowCount = 1
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayout.Size = New System.Drawing.Size(304, 437)
        Me.tableLayout.TabIndex = 2
        '
        'buddyList
        '
        Me.buddyList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IP, Me.Nickname})
        Me.buddyList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buddyList.FullRowSelect = True
        Me.buddyList.HideSelection = False
        Me.buddyList.Location = New System.Drawing.Point(10, 10)
        Me.buddyList.Margin = New System.Windows.Forms.Padding(10)
        Me.buddyList.MultiSelect = False
        Me.buddyList.Name = "buddyList"
        Me.buddyList.Size = New System.Drawing.Size(284, 417)
        Me.buddyList.TabIndex = 2
        Me.buddyList.UseCompatibleStateImageBehavior = False
        Me.buddyList.View = System.Windows.Forms.View.Details
        '
        'IP
        '
        Me.IP.DisplayIndex = 1
        Me.IP.Text = "IP"
        Me.IP.Width = 120
        '
        'Nickname
        '
        Me.Nickname.DisplayIndex = 0
        Me.Nickname.Text = "Nickname"
        Me.Nickname.Width = 120
        '
        'buddyActions
        '
        Me.buddyActions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenameToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.ConnectToolStripMenuItem})
        Me.buddyActions.Name = "buddyActions"
        Me.buddyActions.Size = New System.Drawing.Size(171, 70)
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RenameToolStripMenuItem.Text = "Change nickname"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.Color.Transparent
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(304, 24)
        Me.menuStrip.TabIndex = 4
        Me.menuStrip.Text = "menuStrip"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'frmBuddy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(304, 461)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.tableLayout)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmBuddy"
        Me.Text = "Buddy List"
        Me.tableLayout.ResumeLayout(False)
        Me.buddyActions.ResumeLayout(False)
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableLayout As TableLayoutPanel
    Friend WithEvents buddyList As ListView
    Friend WithEvents Nickname As ColumnHeader
    Friend WithEvents IP As ColumnHeader
    Friend WithEvents buddyActions As ContextMenuStrip
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
End Class
