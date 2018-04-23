Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace Solution2.Module.BusinessObjects
	<DefaultClassOptions> _
	Public Class DomainObject1
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here or place it only when the IsLoading property is false:
			' if (!IsLoading){
			'    It is now OK to place your initialization code here.
			' }
			' or as an alternative, move your initialization code into the AfterConstruction method.
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			' Place here your initialization code.
		End Sub
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class

End Namespace
