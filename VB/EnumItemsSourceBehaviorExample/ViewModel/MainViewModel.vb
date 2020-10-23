Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.POCO
Imports EnumItemsSourceBehaviorExample.Common

Namespace EnumItemsSourceBehaviorExample.ViewModel
	Public Class MainViewModel
		Protected Sub New()
			Users = New ObservableCollection(Of User)() From {User.Create(0, "Jack", UserRole.Administrator), User.Create(1, "Ron", UserRole.User), User.Create(2, "John", UserRole.User), User.Create(3, "Antoni", UserRole.User), User.Create(4, "Paul", UserRole.Moderator)}
			SelectedRole = UserRole.User
		End Sub
		Public Shared Function Create() As MainViewModel
			Return ViewModelSource.Create(Function() New MainViewModel())
		End Function

		Public Overridable Property Users() As ObservableCollection(Of User)
		Public Overridable Property SelectedRole() As UserRole
	End Class
End Namespace
