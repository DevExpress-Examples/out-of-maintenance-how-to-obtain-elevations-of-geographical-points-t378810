using DevExpress.Xpf.Map;
using System.Collections.Generic;
using System.Windows;

namespace BingElevationDataWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void OnLoaded(object sender, RoutedEventArgs e) {
            List<GeoPoint> locations = new List<GeoPoint> {
                new GeoPoint(41.145556, -73.995),
                new GeoPoint(36.131389, -90.937222),
                new GeoPoint(32.175, -80.136389)
            };
            provider.RequestPointsElevations(locations);
        }
    }
}
