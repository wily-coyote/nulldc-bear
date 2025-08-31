<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChallenge
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
		Me.btnAccept = New System.Windows.Forms.Button()
		Me.btnDeny = New System.Windows.Forms.Button()
		Me.lbChallengeText = New System.Windows.Forms.Label()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnPing = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnAccept
		'
		Me.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAccept.Font = NormalForm.BigCaptionFont
		Me.btnAccept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.btnAccept.Location = New System.Drawing.Point(223, 130)
		Me.btnAccept.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAccept.Name = "btnAccept"
		Me.btnAccept.Size = New System.Drawing.Size(268, 87)
		Me.btnAccept.TabIndex = 0
		Me.btnAccept.Text = "LET'S GO!"
		Me.btnAccept.UseVisualStyleBackColor = False
		'
		'btnDeny
		'
		Me.btnDeny.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnDeny.AutoSize = True
		Me.btnDeny.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnDeny.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.btnDeny.Location = New System.Drawing.Point(613, 175)
		Me.btnDeny.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDeny.Name = "btnDeny"
		Me.btnDeny.Size = New System.Drawing.Size(88, 42)
		Me.btnDeny.TabIndex = 1
		Me.btnDeny.Text = "Noooope"
		Me.btnDeny.UseVisualStyleBackColor = False
		'
		'lbChallengeText
		'
		Me.lbChallengeText.AutoSize = True
		Me.lbChallengeText.BackColor = System.Drawing.Color.White
		Me.lbChallengeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbChallengeText.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lbChallengeText.Font = NormalForm.BigCaptionFont
		Me.lbChallengeText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.lbChallengeText.Location = New System.Drawing.Point(0, 0)
		Me.lbChallengeText.Margin = New System.Windows.Forms.Padding(0)
		Me.lbChallengeText.Name = "lbChallengeText"
		Me.lbChallengeText.Size = New System.Drawing.Size(651, 112)
		Me.lbChallengeText.TabIndex = 2
		Me.lbChallengeText.Text = "%Name% has challenged you! to bla bla bla bla bla bla"
		Me.lbChallengeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.lbChallengeText, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(32, 16)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(651, 112)
		Me.TableLayoutPanel1.TabIndex = 3
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
		Me.TableLayoutPanel2.ColumnCount = 1
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.btnPing, 0, 1)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(499, 130)
		Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(106, 87)
		Me.TableLayoutPanel2.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Location = New System.Drawing.Point(5, 1)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(96, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Ping: N/A"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnPing
		'
		Me.btnPing.AutoSize = True
		Me.btnPing.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.btnPing.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPing.Location = New System.Drawing.Point(1, 41)
		Me.btnPing.Margin = New System.Windows.Forms.Padding(0)
		Me.btnPing.Name = "btnPing"
		Me.btnPing.Size = New System.Drawing.Size(104, 45)
		Me.btnPing.TabIndex = 1
		Me.btnPing.Text = "Re-Ping"
		Me.btnPing.UseVisualStyleBackColor = False
		'
		'frmChallenge
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DimGray
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(715, 230)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.btnDeny)
		Me.Controls.Add(Me.btnAccept)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmChallenge"
		Me.Padding = New System.Windows.Forms.Padding(10)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Defend Your Honor!"
		Me.TransparencyKey = System.Drawing.Color.DimGray
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnAccept As Button
	Friend WithEvents btnDeny As Button
	Friend WithEvents lbChallengeText As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents btnPing As Button
End Class
