<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642392/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T196946)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF MVVM Framework - Bind a Control to an Enumeration with EnumItemsSourceBehavior

You can use this behavior with the following controls:

* [ListBoxEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ListBoxEdit)
* [ItemsControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol)
* [LookUpEditBase](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase)

Each enumeration member should contain the Display attribute. This attribute is a standard [Display attribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute) that allows you to specify localizable strings for types and members of entity partial classes.

<!-- default file list -->
## Files to Look At

* [User.cs](./CS/EnumItemsSourceBehaviorExample/Common/User.cs) (VB: [User.vb](./VB/EnumItemsSourceBehaviorExample/Common/User.vb))
* [UserRole.cs](./CS/EnumItemsSourceBehaviorExample/Common/UserRole.cs) (VB: [UserRole.vb](./VB/EnumItemsSourceBehaviorExample/Common/UserRole.vb))
* [MainView.xaml](./CS/EnumItemsSourceBehaviorExample/View/MainView.xaml) (VB: [MainView.xaml](./VB/EnumItemsSourceBehaviorExample/View/MainView.xaml))
* [MainViewModel.cs](./CS/EnumItemsSourceBehaviorExample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/EnumItemsSourceBehaviorExample/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [CompositeCommandBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.EnumItemsSourceBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
