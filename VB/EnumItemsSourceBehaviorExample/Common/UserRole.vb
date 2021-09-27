Imports DevExpress.Mvvm.DataAnnotations
Imports System.ComponentModel.DataAnnotations

Namespace EnumItemsSourceBehaviorExample.Common

    Public Enum UserRole
        <Image("pack://application:,,,/Images/Admin.png"), Display(Name:="Admin", Description:="High level of access")>
        Administrator
        <Image("pack://application:,,,/Images/Moderator.png"), Display(Name:="Moderator", Description:="Average level of access")>
        Moderator
        <Image("pack://application:,,,/Images/User.png"), Display(Name:="User", Description:="Low level of access")>
        User
    End Enum
End Namespace
