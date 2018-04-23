Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace WinSolution.Module
	<DefaultClassOptions> _
	Public Class DomainObject1
		Inherits DomainObjectBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _propertyName1 As String
		Public Property PropertyName1() As String
			Get
				Return _propertyName1
			End Get
			Set(ByVal value As String)
				SetPropertyValue("PropertyName1", _propertyName1, value)
			End Set
		End Property
	End Class
End Namespace
