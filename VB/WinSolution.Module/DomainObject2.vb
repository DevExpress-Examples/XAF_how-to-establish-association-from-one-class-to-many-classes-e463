Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace WinSolution.Module
	<DefaultClassOptions> _
	Public Class DomainObject2
		Inherits DomainObjectBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _propertyName2 As String
		Public Property PropertyName2() As String
			Get
				Return _propertyName2
			End Get
			Set(ByVal value As String)
				SetPropertyValue("PropertyName2", _propertyName2, value)
			End Set
		End Property
	End Class
End Namespace
