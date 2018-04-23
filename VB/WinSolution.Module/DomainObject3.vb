Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Persistent.Base
Imports DevExpress.Xpo

Namespace WinSolution.Module
	<DefaultClassOptions> _
	Public Class DomainObject3
		Inherits DomainObjectBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _propertyName3 As String
		Public Property PropertyName3() As String
			Get
				Return _propertyName3
			End Get
			Set(ByVal value As String)
				SetPropertyValue("PropertyName3", _propertyName3, value)
			End Set
		End Property
	End Class
End Namespace
