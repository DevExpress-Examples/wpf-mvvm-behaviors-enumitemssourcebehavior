Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.Mvvm.POCO

Namespace EnumItemsSourceBehaviorExample.Common

    Public Class User

        Protected Sub New(ByVal name As String, ByVal iD As Integer, ByVal role As UserRole)
            Me.Name = name
            Me.ID = iD
            Me.Role = role
        End Sub

        Public Shared Function Create(ByVal id As Integer, ByVal name As String, ByVal role As UserRole) As User
            Return ViewModelSource.Create(Function() New User(name, id, role))
        End Function

        Public Property Name As String

        Public Property ID As Integer

        Public Property Role As UserRole
    End Class
End Namespace
