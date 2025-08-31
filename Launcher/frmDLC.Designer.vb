<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDLC
    Inherits NormalForm

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
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.DLCContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRomsFolder = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lnkRoms = New System.Windows.Forms.LinkLabel()
        Me.tc_games = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Search_ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbDisclaimer = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DLCCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultidiskPlaylistCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DLCContainer.SuspendLayout()
        Me.tc_games.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DLCContainer.SetColumnSpan(Me.btnDownload, 2)
        Me.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDownload.Location = New System.Drawing.Point(10, 553)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(641, 41)
        Me.btnDownload.TabIndex = 1
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'DLCContainer
        '
        Me.DLCContainer.ColumnCount = 2
        Me.DLCContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74103!))
        Me.DLCContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25897!))
        Me.DLCContainer.Controls.Add(Me.btnClose, 0, 5)
        Me.DLCContainer.Controls.Add(Me.btnRomsFolder, 1, 5)
        Me.DLCContainer.Controls.Add(Me.btnDownload, 0, 3)
        Me.DLCContainer.Controls.Add(Me.ProgressBar1, 0, 2)
        Me.DLCContainer.Controls.Add(Me.lnkRoms, 0, 4)
        Me.DLCContainer.Controls.Add(Me.tc_games, 0, 1)
        Me.DLCContainer.Controls.Add(Me.lbDisclaimer, 0, 6)
        Me.DLCContainer.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.DLCContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DLCContainer.Location = New System.Drawing.Point(0, 26)
        Me.DLCContainer.Name = "DLCContainer"
        Me.DLCContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.DLCContainer.RowCount = 7
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DLCContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DLCContainer.Size = New System.Drawing.Size(661, 681)
        Me.DLCContainer.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(10, 612)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(165, 41)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRomsFolder
        '
        Me.btnRomsFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRomsFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRomsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRomsFolder.Location = New System.Drawing.Point(175, 612)
        Me.btnRomsFolder.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRomsFolder.Name = "btnRomsFolder"
        Me.btnRomsFolder.Size = New System.Drawing.Size(476, 41)
        Me.btnRomsFolder.TabIndex = 6
        Me.btnRomsFolder.Text = "Open Naomi/Atomiswave Roms Folder"
        Me.btnRomsFolder.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.DLCContainer.SetColumnSpan(Me.ProgressBar1, 2)
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 530)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(641, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'lnkRoms
        '
        Me.lnkRoms.AutoSize = True
        Me.lnkRoms.BackColor = System.Drawing.Color.Transparent
        Me.DLCContainer.SetColumnSpan(Me.lnkRoms, 2)
        Me.lnkRoms.Location = New System.Drawing.Point(13, 594)
        Me.lnkRoms.Name = "lnkRoms"
        Me.lnkRoms.Size = New System.Drawing.Size(303, 18)
        Me.lnkRoms.TabIndex = 4
        Me.lnkRoms.TabStop = True
        Me.lnkRoms.Text = "Can't download? Click here to manually get games"
        '
        'tc_games
        '
        Me.DLCContainer.SetColumnSpan(Me.tc_games, 2)
        Me.tc_games.Controls.Add(Me.TabPage1)
        Me.tc_games.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_games.Location = New System.Drawing.Point(10, 44)
        Me.tc_games.Margin = New System.Windows.Forms.Padding(0)
        Me.tc_games.Multiline = True
        Me.tc_games.Name = "tc_games"
        Me.tc_games.SelectedIndex = 0
        Me.tc_games.Size = New System.Drawing.Size(641, 486)
        Me.tc_games.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Search_ListView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(633, 455)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Search_ListView
        '
        Me.Search_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.Search_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Search_ListView.FullRowSelect = True
        Me.Search_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.Search_ListView.HideSelection = False
        Me.Search_ListView.Location = New System.Drawing.Point(0, 0)
        Me.Search_ListView.Margin = New System.Windows.Forms.Padding(0)
        Me.Search_ListView.MultiSelect = False
        Me.Search_ListView.Name = "Search_ListView"
        Me.Search_ListView.Size = New System.Drawing.Size(633, 455)
        Me.Search_ListView.TabIndex = 0
        Me.Search_ListView.UseCompatibleStateImageBehavior = False
        Me.Search_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "URL"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Platform"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "folder"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "extract"
        '
        'lbDisclaimer
        '
        Me.lbDisclaimer.AutoSize = True
        Me.lbDisclaimer.BackColor = System.Drawing.Color.Transparent
        Me.DLCContainer.SetColumnSpan(Me.lbDisclaimer, 2)
        Me.lbDisclaimer.Location = New System.Drawing.Point(13, 653)
        Me.lbDisclaimer.Name = "lbDisclaimer"
        Me.lbDisclaimer.Size = New System.Drawing.Size(249, 18)
        Me.lbDisclaimer.TabIndex = 9
        Me.lbDisclaimer.Text = "Disclaimer: Some games might not work"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.DLCContainer.SetColumnSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSearch, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSearch, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(641, 34)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(57, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(517, 25)
        Me.TextBox1.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSearch.Location = New System.Drawing.Point(580, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 28)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSearch.Location = New System.Drawing.Point(3, 0)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(48, 34)
        Me.lbSearch.TabIndex = 14
        Me.lbSearch.Text = "Search"
        Me.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DLCCreatorToolStripMenuItem, Me.MultidiskPlaylistCreatorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 26)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DLCCreatorToolStripMenuItem
        '
        Me.DLCCreatorToolStripMenuItem.Name = "DLCCreatorToolStripMenuItem"
        Me.DLCCreatorToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.DLCCreatorToolStripMenuItem.Text = "DLC Creator"
        '
        'MultidiskPlaylistCreatorToolStripMenuItem
        '
        Me.MultidiskPlaylistCreatorToolStripMenuItem.Name = "MultidiskPlaylistCreatorToolStripMenuItem"
        Me.MultidiskPlaylistCreatorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MultidiskPlaylistCreatorToolStripMenuItem.Text = "Multidisk Playlist Creator"
        '
        'frmDLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(661, 707)
        Me.Controls.Add(Me.DLCContainer)
        Me.Controls.Add(Me.MenuStrip1)
	
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDLC"
        Me.Text = "Downloadable Content"
        Me.DLCContainer.ResumeLayout(False)
        Me.DLCContainer.PerformLayout()
        Me.tc_games.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDownload As Button
    Friend WithEvents DLCContainer As TableLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lnkRoms As LinkLabel
    Friend WithEvents btnRomsFolder As Button
    Friend WithEvents tc_games As TabControl
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lbDisclaimer As Label
    Friend WithEvents DLCCreatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultidiskPlaylistCreatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lbSearch As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Search_ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
