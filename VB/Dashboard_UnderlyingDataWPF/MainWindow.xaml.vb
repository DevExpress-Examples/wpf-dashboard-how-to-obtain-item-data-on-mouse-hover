Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWpf
Imports System.Windows

Namespace Dashboard_UnderlyingDataWPF

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub DashboardControl_DashboardItemMouseMove(ByVal sender As Object, ByVal e As DashboardItemMouseActionWpfEventArgs)
            If Not Equals(e.DashboardItemName, Nothing) Then
                Dim underlyingData As DashboardUnderlyingDataSet = e.GetUnderlyingData()
                Me.myGrid.ItemsSource = underlyingData
                tooltip.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint
            End If
        End Sub

        Private Sub DashboardControl_DashboardItemMouseEnter(ByVal sender As Object, ByVal e As DashboardItemMouseWpfEventArgs)
            tooltip.IsOpen = True
        End Sub

        Private Sub DashboardControl_DashboardItemMouseLeave(ByVal sender As Object, ByVal e As DashboardItemMouseWpfEventArgs)
            tooltip.IsOpen = False
        End Sub
    End Class
End Namespace
