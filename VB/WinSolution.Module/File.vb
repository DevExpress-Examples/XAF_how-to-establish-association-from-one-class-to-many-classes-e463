Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module
	Public Class File
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _name As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _name, value)
			End Set
		End Property
		Private _domainObjectBase As DomainObjectBase
		<Association("DomainObjectBase-Files")> _
		Public Property DomainObjectBase() As DomainObjectBase
			Get
				Return _domainObjectBase
			End Get
			Set(ByVal value As DomainObjectBase)
				SetPropertyValue("DomainObjectBase", _domainObjectBase, value)
			End Set
		End Property
	End Class
End Namespace
