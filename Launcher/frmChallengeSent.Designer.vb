<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallengeSent
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnNope = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Font = NormalForm.BigCaptionFont
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(600, 100)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Waiting for Reply from AkumaLover_69"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnNope
		'
		Me.btnNope.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnNope.AutoSize = True
		Me.btnNope.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btnNope.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.btnNope.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnNope.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.btnNope.Location = New System.Drawing.Point(512, 188)
		Me.btnNope.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNope.Name = "btnNope"
		Me.btnNope.Size = New System.Drawing.Size(189, 28)
		Me.btnNope.TabIndex = 5
		Me.btnNope.Text = "Ain't no one got time for that"
		Me.btnNope.UseVisualStyleBackColor = False
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(57, 65)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 100)
		Me.TableLayoutPanel1.TabIndex = 6
		'
		'frmChallengeSent
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DimGray
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(715, 230)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.btnNope)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmChallengeSent"
		Me.Padding = New System.Windows.Forms.Padding(10)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Let's get it on!"
		Me.TransparencyKey = System.Drawing.Color.DimGray
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents btnNope As Button
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
