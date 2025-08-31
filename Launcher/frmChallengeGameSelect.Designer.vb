<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallengeGameSelect
    Inherits NormalForm

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
        Me.GameSelectContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.tc_games = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tb_nulldc = New System.Windows.Forms.TableLayoutPanel()
        Me.cbDelay = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRegion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_nulldc_emulator = New System.Windows.Forms.ComboBox()
        Me.tb_mednafen = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Multitap = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Serverlist = New System.Windows.Forms.ComboBox()
        Me.tb_gamekey = New System.Windows.Forms.TextBox()
        Me.cb_nokey = New System.Windows.Forms.CheckBox()
        Me.btnLetsGo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultidiscPlaylistCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameSelectContainer.SuspendLayout()
        Me.tc_games.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.tb_nulldc.SuspendLayout()
        Me.tb_mednafen.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameSelectContainer
        '
        Me.GameSelectContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GameSelectContainer.ColumnCount = 2
        Me.GameSelectContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GameSelectContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.GameSelectContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GameSelectContainer.Controls.Add(Me.tc_games, 0, 0)
        Me.GameSelectContainer.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.GameSelectContainer.Controls.Add(Me.btnLetsGo, 1, 1)
        Me.GameSelectContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameSelectContainer.Location = New System.Drawing.Point(0, 26)
        Me.GameSelectContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.GameSelectContainer.Name = "GameSelectContainer"
        Me.GameSelectContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.GameSelectContainer.RowCount = 2
        Me.GameSelectContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GameSelectContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GameSelectContainer.Size = New System.Drawing.Size(762, 466)
        Me.GameSelectContainer.TabIndex = 29
        '
        'tc_games
        '
        Me.GameSelectContainer.SetColumnSpan(Me.tc_games, 2)
        Me.tc_games.Controls.Add(Me.TabPage1)
        Me.tc_games.Controls.Add(Me.TabPage2)
        Me.tc_games.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_games.Location = New System.Drawing.Point(13, 13)
        Me.tc_games.Multiline = True
        Me.tc_games.Name = "tc_games"
        Me.tc_games.SelectedIndex = 0
        Me.tc_games.Size = New System.Drawing.Size(736, 241)
        Me.tc_games.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(728, 246)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.tb_nulldc)
        Me.FlowLayoutPanel1.Controls.Add(Me.tb_mednafen)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 260)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(536, 193)
        Me.FlowLayoutPanel1.TabIndex = 27
        '
        'tb_nulldc
        '
        Me.tb_nulldc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_nulldc.AutoSize = True
        Me.tb_nulldc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tb_nulldc.BackColor = System.Drawing.Color.Transparent
        Me.tb_nulldc.ColumnCount = 2
        Me.tb_nulldc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tb_nulldc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tb_nulldc.Controls.Add(Me.cbDelay, 0, 0)
        Me.tb_nulldc.Controls.Add(Me.Label2, 0, 0)
        Me.tb_nulldc.Controls.Add(Me.Label4, 0, 1)
        Me.tb_nulldc.Controls.Add(Me.cbRegion, 1, 1)
        Me.tb_nulldc.Controls.Add(Me.Label6, 0, 2)
        Me.tb_nulldc.Controls.Add(Me.cb_nulldc_emulator, 1, 2)
        Me.tb_nulldc.Location = New System.Drawing.Point(0, 0)
        Me.tb_nulldc.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_nulldc.Name = "tb_nulldc"
        Me.tb_nulldc.RowCount = 4
        Me.tb_nulldc.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_nulldc.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_nulldc.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_nulldc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tb_nulldc.Size = New System.Drawing.Size(536, 98)
        Me.tb_nulldc.TabIndex = 25
        '
        'cbDelay
        '
        Me.cbDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbDelay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.cbDelay.FormattingEnabled = True
        Me.cbDelay.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cbDelay.Location = New System.Drawing.Point(107, 3)
        Me.cbDelay.Name = "cbDelay"
        Me.cbDelay.Size = New System.Drawing.Size(426, 26)
        Me.cbDelay.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Simulated Delay"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 34)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Region"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbRegion
        '
        Me.cbRegion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbRegion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegion.FormattingEnabled = True
        Me.cbRegion.Items.AddRange(New Object() {"JPN", "USA", "EUR"})
        Me.cbRegion.Location = New System.Drawing.Point(108, 36)
        Me.cbRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Size = New System.Drawing.Size(424, 26)
        Me.cbRegion.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 32)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Emulator"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_nulldc_emulator
        '
        Me.cb_nulldc_emulator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cb_nulldc_emulator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_nulldc_emulator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_nulldc_emulator.FormattingEnabled = True
        Me.cb_nulldc_emulator.Items.AddRange(New Object() {"NullDC", "Flycast (Rollback Beta)"})
        Me.cb_nulldc_emulator.Location = New System.Drawing.Point(107, 69)
        Me.cb_nulldc_emulator.Name = "cb_nulldc_emulator"
        Me.cb_nulldc_emulator.Size = New System.Drawing.Size(426, 26)
        Me.cb_nulldc_emulator.TabIndex = 28
        '
        'tb_mednafen
        '
        Me.tb_mednafen.AutoSize = True
        Me.tb_mednafen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tb_mednafen.BackColor = System.Drawing.Color.Transparent
        Me.tb_mednafen.ColumnCount = 3
        Me.tb_mednafen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tb_mednafen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tb_mednafen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tb_mednafen.Controls.Add(Me.Label5, 0, 2)
        Me.tb_mednafen.Controls.Add(Me.Label1, 0, 1)
        Me.tb_mednafen.Controls.Add(Me.cb_Multitap, 1, 1)
        Me.tb_mednafen.Controls.Add(Me.Label3, 0, 0)
        Me.tb_mednafen.Controls.Add(Me.cb_Serverlist, 1, 0)
        Me.tb_mednafen.Controls.Add(Me.tb_gamekey, 1, 2)
        Me.tb_mednafen.Controls.Add(Me.cb_nokey, 2, 2)
        Me.tb_mednafen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_mednafen.Location = New System.Drawing.Point(0, 98)
        Me.tb_mednafen.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_mednafen.Name = "tb_mednafen"
        Me.tb_mednafen.RowCount = 3
        Me.tb_mednafen.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_mednafen.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_mednafen.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tb_mednafen.Size = New System.Drawing.Size(536, 95)
        Me.tb_mednafen.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 31)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Gamekey"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 32)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "MultiTap"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_Multitap
        '
        Me.tb_mednafen.SetColumnSpan(Me.cb_Multitap, 2)
        Me.cb_Multitap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Multitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Multitap.FormattingEnabled = True
        Me.cb_Multitap.Items.AddRange(New Object() {"None", "Port 1", "Port 2", "Port 1+2"})
        Me.cb_Multitap.Location = New System.Drawing.Point(67, 35)
        Me.cb_Multitap.Name = "cb_Multitap"
        Me.cb_Multitap.Size = New System.Drawing.Size(466, 26)
        Me.cb_Multitap.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Server"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_Serverlist
        '
        Me.tb_mednafen.SetColumnSpan(Me.cb_Serverlist, 2)
        Me.cb_Serverlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_Serverlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Serverlist.FormattingEnabled = True
        Me.cb_Serverlist.Location = New System.Drawing.Point(67, 3)
        Me.cb_Serverlist.Name = "cb_Serverlist"
        Me.cb_Serverlist.Size = New System.Drawing.Size(466, 26)
        Me.cb_Serverlist.TabIndex = 29
        '
        'tb_gamekey
        '
        Me.tb_gamekey.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_gamekey.Location = New System.Drawing.Point(67, 67)
        Me.tb_gamekey.Name = "tb_gamekey"
        Me.tb_gamekey.Size = New System.Drawing.Size(397, 25)
        Me.tb_gamekey.TabIndex = 34
        '
        'cb_nokey
        '
        Me.cb_nokey.AutoSize = True
        Me.cb_nokey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_nokey.Location = New System.Drawing.Point(467, 64)
        Me.cb_nokey.Margin = New System.Windows.Forms.Padding(0)
        Me.cb_nokey.Name = "cb_nokey"
        Me.cb_nokey.Size = New System.Drawing.Size(69, 31)
        Me.cb_nokey.TabIndex = 35
        Me.cb_nokey.Text = "No Key"
        Me.cb_nokey.UseVisualStyleBackColor = True
        '
        'btnLetsGo
        '
        Me.btnLetsGo.AutoSize = True
        Me.btnLetsGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLetsGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLetsGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLetsGo.Font = NormalForm.BigCaptionFont
        Me.btnLetsGo.Location = New System.Drawing.Point(555, 260)
        Me.btnLetsGo.Name = "btnLetsGo"
        Me.btnLetsGo.Size = New System.Drawing.Size(194, 193)
        Me.btnLetsGo.TabIndex = 1
        Me.btnLetsGo.Text = "LET'S GO!"
        Me.btnLetsGo.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DLCToolStripMenuItem, Me.MultidiscPlaylistCreatorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 26)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DLCToolStripMenuItem
        '
        Me.DLCToolStripMenuItem.Name = "DLCToolStripMenuItem"
        Me.DLCToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.DLCToolStripMenuItem.Text = "Free DLC"
        '
        'MultidiscPlaylistCreatorToolStripMenuItem
        '
        Me.MultidiscPlaylistCreatorToolStripMenuItem.Name = "MultidiscPlaylistCreatorToolStripMenuItem"
        Me.MultidiscPlaylistCreatorToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MultidiscPlaylistCreatorToolStripMenuItem.Text = "Multidisc Playlist Creator"
        '
        'frmChallengeGameSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(762, 492)
        Me.Controls.Add(Me.GameSelectContainer)
        Me.Controls.Add(Me.MenuStrip1)
	
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(770, 39)
        Me.Name = "frmChallengeGameSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Select"
        Me.GameSelectContainer.ResumeLayout(False)
        Me.GameSelectContainer.PerformLayout()
        Me.tc_games.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.tb_nulldc.ResumeLayout(False)
        Me.tb_nulldc.PerformLayout()
        Me.tb_mednafen.ResumeLayout(False)
        Me.tb_mednafen.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameSelectContainer As TableLayoutPanel
    Friend WithEvents tb_nulldc As TableLayoutPanel
    Friend WithEvents cbDelay As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbRegion As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DLCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultidiscPlaylistCreatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tc_games As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_nulldc_emulator As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnLetsGo As Button
    Friend WithEvents tb_mednafen As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Multitap As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_Serverlist As ComboBox
    Friend WithEvents tb_gamekey As TextBox
    Friend WithEvents cb_nokey As CheckBox
End Class
