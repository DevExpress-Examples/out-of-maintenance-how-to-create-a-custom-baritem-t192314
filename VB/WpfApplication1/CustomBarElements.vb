Imports DevExpress.Xpf.Bars
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

Namespace WpfApplication1
    Public NotInheritable Class CustomBarElementsRegistrator

        Private Sub New()
        End Sub

        Public Shared Sub Register()
            BarItemLinkCreator.Default.RegisterObject(GetType(MyBarButtonItem), GetType(MyBarButtonItemLink), Function(link) New MyBarButtonItemLink())
            BarItemLinkControlCreator.Default.RegisterObject(GetType(MyBarButtonItemLink), GetType(MyBarButtonItemLinkControl), Function(link) New MyBarButtonItemLinkControl(CType(link, MyBarButtonItemLink)))
        End Sub
    End Class

    Public Class MyBarButtonItemLinkControl
        Inherits BarButtonItemLinkControl

        Public Sub New()
        End Sub
        Public Sub New(ByVal link As MyBarButtonItemLink)
            MyBase.New(link)

        End Sub

        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()

            'demo test
            Me.LayoutPanel.Background = Brushes.Red
        End Sub
    End Class

    Public Class MyBarButtonItemLink
        Inherits BarButtonItemLink

    End Class


    Public Class MyBarButtonItem
        Inherits BarButtonItem

        Protected Overrides Function GetLinkType() As Type
            Return GetType(MyBarButtonItemLink)
        End Function
    End Class

End Namespace
