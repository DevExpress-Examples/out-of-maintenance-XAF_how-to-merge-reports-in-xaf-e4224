Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Reports.Win

Namespace Solution2.Module.Win.Controllers
	Partial Public Class ReportCustomController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private reportService As WinReportServiceController
		Protected Overrides Sub OnFrameAssigned()
			MyBase.OnFrameAssigned()

			reportService = Frame.GetController(Of WinReportServiceController)()
			If reportService IsNot Nothing Then
				AddHandler reportService.CustomShowPreview, AddressOf reportService_CustomShowPreview
			End If
		End Sub
		Private Sub reportService_CustomShowPreview(ByVal sender As Object, ByVal e As CustomShowPreviewEventArgs)
			Dim coverPageReport As New XtraReport1()
			coverPageReport.CreateDocument()

			e.Report.CreateDocument()

			coverPageReport.Pages.AddRange(e.Report.Pages)
			coverPageReport.ShowPreviewDialog()

			e.Handled = True
		End Sub
	End Class
End Namespace
