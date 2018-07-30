using DevExpress.DashboardCommon;
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

        private void DashboardControl_DashboardItemMouseMove(object sender, DevExpress.DashboardWpf.DashboardItemMouseActionWpfEventArgs e)
        {
            if (e.DashboardItemName != null)
            {
                DashboardUnderlyingDataSet underlyingData = e.GetUnderlyingData();
                myGrid.ItemsSource = underlyingData;
                tooltip.Placement = System.Windows.Controls.Primitives.PlacementMode.MousePoint;
            }
        }

        private void DashboardControl_DashboardItemMouseEnter(object sender, DevExpress.DashboardWpf.DashboardItemMouseWpfEventArgs e)
        {
            tooltip.IsOpen = true;
        }

        private void DashboardControl_DashboardItemMouseLeave(object sender, DevExpress.DashboardWpf.DashboardItemMouseWpfEventArgs e)
        {
            tooltip.IsOpen = false;
        }
    }
}
