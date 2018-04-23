Imports DevExpress.Xpf.Map
Imports System.Collections.Generic
Imports System.Windows

Namespace BingElevationDataWpf
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim locations As New List(Of GeoPoint)() From { _
                New GeoPoint(41.145556, -73.995), _
                New GeoPoint(36.131389, -90.937222), _
                New GeoPoint(32.175, -80.136389) _
            }
            provider.RequestPointsElevations(locations)
        End Sub
    End Class
End Namespace
