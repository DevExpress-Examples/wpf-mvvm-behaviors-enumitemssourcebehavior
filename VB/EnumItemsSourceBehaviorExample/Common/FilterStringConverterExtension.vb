Imports System
Imports System.Linq
Imports System.Windows.Markup
Imports System.Collections.Generic

Namespace EnumItemsSourceBehaviorExample.Common

    Public Class FilterStringConverterExtension
        Inherits MarkupExtension

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return New FilterStringConverter()
        End Function
    End Class
End Namespace
