Imports System
Imports System.Windows.Markup

Namespace EnumItemsSourceBehaviorExample.Common

    Public Class FilterStringConverterExtension
        Inherits MarkupExtension

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return New FilterStringConverter()
        End Function
    End Class
End Namespace
