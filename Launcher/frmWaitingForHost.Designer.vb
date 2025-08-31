<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWaitingForHost
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
		Me.lbWaitingForHost = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnRetryVMU = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lbWaitingForHost
		'
		Me.lbWaitingForHost.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.lbWaitingForHost.AutoSize = True
		Me.lbWaitingForHost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lbWaitingForHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbWaitingForHost.Font = NormalForm.BigCaptionFont
		Me.lbWaitingForHost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
		Me.lbWaitingForHost.Location = New System.Drawing.Point(251, 10)
		Me.lbWaitingForHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbWaitingForHost.Name = "lbWaitingForHost"
		Me.lbWaitingForHost.Size = New System.Drawing.Size(212, 38)
		Me.lbWaitingForHost.TabIndex = 0
		Me.lbWaitingForHost.Text = "Waiting For Host"
		Me.lbWaitingForHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Location = New System.Drawing.Point(182, 2)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(350, 207)
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.AutoSize = True
		Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.btnCancel.Location = New System.Drawing.Point(613, 174)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(88, 42)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'btnRetryVMU
		'
		Me.btnRetryVMU.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnRetryVMU.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.btnRetryVMU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnRetryVMU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
		Me.btnRetryVMU.Location = New System.Drawing.Point(182, 164)
		Me.btnRetryVMU.Margin = New System.Windows.Forms.Padding(4)
		Me.btnRetryVMU.Name = "btnRetryVMU"
		Me.btnRetryVMU.Size = New System.Drawing.Size(350, 52)
		Me.btnRetryVMU.TabIndex = 3
		Me.btnRetryVMU.Text = "Retry getting VMU"
		Me.btnRetryVMU.UseVisualStyleBackColor = False
		'
		'frmWaitingForHost
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DimGray
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(715, 230)
		Me.Controls.Add(Me.btnRetryVMU)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.lbWaitingForHost)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "frmWaitingForHost"
		Me.Padding = New System.Windows.Forms.Padding(10)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Waiting for Host"
		Me.TransparencyKey = System.Drawing.Color.DimGray
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbWaitingForHost As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnRetryVMU As Button
End Class
