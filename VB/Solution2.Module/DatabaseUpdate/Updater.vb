Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security
Imports Solution2.Module.BusinessObjects
Imports DevExpress.ExpressApp.Reports

Namespace Solution2.Module.DatabaseUpdate
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			If ObjectSpace.GetObjects(Of DomainObject1)().Count = 0 Then
				Dim obj1 As DomainObject1 = ObjectSpace.CreateObject(Of DomainObject1)()
				obj1.Name = "object 1"
			End If

			If ObjectSpace.GetObjects(Of ReportData)().Count = 0 Then
				Dim reportData1 As ReportData = ObjectSpace.CreateObject(Of ReportData)()
				Dim rep As New XafReport()
				rep.ObjectSpace = ObjectSpace
				rep.LoadLayout(Me.GetType().Assembly.GetManifestResourceStream("Test1.repx"))
				rep.ReportName = "Test1"
				reportData1.SaveXtraReport(rep)
				reportData1.IsInplaceReport = True
				'report1.SaveXtraReport();
			End If
			ObjectSpace.CommitChanges()
		End Sub
	End Class
End Namespace
