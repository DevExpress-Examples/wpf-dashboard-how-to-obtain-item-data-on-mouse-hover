using DevExpress.DashboardCommon;
using DevExpress.DashboardWpf;
using System.Windows;

namespace Dashboard_UnderlyingDataWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DashboardControl_DashboardItemMouseMove(object sender, DashboardItemMouseActionWpfEventArgs e)
        {
            if (e.DashboardItemName != null)
            {
                DashboardUnderlyingDataSet underlyingData = e.GetUnderlyingData();
                myGrid.ItemsSource = underlyingData;
                tooltip.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint;
            }
        }

        private void DashboardControl_DashboardItemMouseEnter(object sender, DashboardItemMouseWpfEventArgs e)
        {
            tooltip.IsOpen = true;
        }

        private void DashboardControl_DashboardItemMouseLeave(object sender, DashboardItemMouseWpfEventArgs e)
        {
            tooltip.IsOpen = false;
        }
    }
}
