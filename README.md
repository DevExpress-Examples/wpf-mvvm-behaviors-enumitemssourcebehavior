<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642392/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T196946)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF MVVM Framework - Bind a Control to an Enumeration with EnumItemsSourceBehavior

This example uses the [EnumItemsSourceBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.EnumItemsSourceBehavior) to bind the [ComboBoxEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ComboBoxEdit) to the `UserRole` enumeration:

![image](https://user-images.githubusercontent.com/65009440/219645482-806eb846-4833-4d8e-ae20-1ff4e7b203b3.png)

You can use this behavior with the following controls:

* [ListBoxEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ListBoxEdit)
* [ItemsControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol)
* [LookUpEditBase](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase) descendants

You can also apply attributes from the [System.ComponentModel.DataAnnotations](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations) and [DevExpress.Mvvm.DataAnnotations](https://docs.devexpress.com/CoreLibraries/DevExpress.Mvvm.DataAnnotations) namespaces to enumeration members.

<!-- default file list -->
## Files to Look At

* [User.cs](./CS/EnumItemsSourceBehaviorExample/Common/User.cs) (VB: [User.vb](./VB/EnumItemsSourceBehaviorExample/Common/User.vb))
* [UserRole.cs](./CS/EnumItemsSourceBehaviorExample/Common/UserRole.cs) (VB: [UserRole.vb](./VB/EnumItemsSourceBehaviorExample/Common/UserRole.vb))
* [MainView.xaml](./CS/EnumItemsSourceBehaviorExample/View/MainView.xaml) (VB: [MainView.xaml](./VB/EnumItemsSourceBehaviorExample/View/MainView.xaml))
* [MainViewModel.cs](./CS/EnumItemsSourceBehaviorExample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/EnumItemsSourceBehaviorExample/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [EnumItemsSourceBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.EnumItemsSourceBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-enumitemssourcebehavior&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-enumitemssourcebehavior&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
