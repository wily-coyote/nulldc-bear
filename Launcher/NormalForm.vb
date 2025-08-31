Public Class NormalForm
	Inherits Form
	Public Sub New()
		MyBase.New()
		Font = SystemFonts.CaptionFont
	End Sub

	Public Shared ReadOnly Property BigCaptionFont As New Font(SystemFonts.CaptionFont.FontFamily,
										  SystemFonts.CaptionFont.SizeInPoints * (12.0 / 9.0))
End Class
