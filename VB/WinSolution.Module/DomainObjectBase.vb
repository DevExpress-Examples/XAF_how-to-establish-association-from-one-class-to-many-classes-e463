Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module
	Public MustInherit Class DomainObjectBase
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		<Association("DomainObjectBase-Files"), Aggregated> _
		Public ReadOnly Property Files() As XPCollection(Of File)
			Get
				Return GetCollection(Of File)("Files")
			End Get
		End Property
	End Class
End Namespace
