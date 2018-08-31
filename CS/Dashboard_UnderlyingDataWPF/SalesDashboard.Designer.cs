namespace Dashboard_UnderlyingDataWPF
{
    partial class SalesDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.CardCompactLayoutTemplate cardCompactLayoutTemplate1 = new DevExpress.DashboardCommon.CardCompactLayoutTemplate();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.dashboardExtractDataSource1 = new DevExpress.DashboardCommon.DashboardExtractDataSource();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.cardDashboardItem1 = new DevExpress.DashboardCommon.CardDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pivotDashboardItem1
            // 
            dimension1.DataMember = "OrderDate";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            measure1.DataMember = "ExtendedPrice";
            dimension2.DataMember = "CategoryName";
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2");
            this.pivotDashboardItem1.DataSource = this.dashboardExtractDataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact;
            this.pivotDashboardItem1.Name = "Pivot 1";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pivotDashboardItem1.ShowCaption = false;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // dashboardExtractDataSource1
            // 
            calculatedField1.Expression = "[Quantity] * [UnitPrice]";
            calculatedField1.Name = "RegularPrice";
            this.dashboardExtractDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1});
            this.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1";
            this.dashboardExtractDataSource1.FileName = "|DataDirectory|\\Data\\NWind_SalesPerson.dat";
            this.dashboardExtractDataSource1.Name = "Extract Data Source 1";
            // 
            // chartDashboardItem1
            // 
            dimension3.DataMember = "OrderDate";
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure2.DataMember = "ExtendedPrice";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1");
            this.chartDashboardItem1.DataSource = this.dashboardExtractDataSource1;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Chart 1";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.AddDataItem("Value", measure2);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = false;
            // 
            // cardDashboardItem1
            // 
            measure3.DataMember = "ExtendedPrice";
            measure4.DataMember = "RegularPrice";
            card1.DeltaOptions.ResultIndicationThreshold = new decimal(new int[] {
            5,
            0,
            0,
            0});
            card1.LayoutDeltaOptions.ResultIndicationThreshold = new decimal(new int[] {
            5,
            0,
            0,
            0});
            cardCompactLayoutTemplate1.BottomSubValue1.DimensionIndex = 0;
            cardCompactLayoutTemplate1.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation;
            cardCompactLayoutTemplate1.BottomSubValue1.Visible = true;
            cardCompactLayoutTemplate1.BottomSubValue2.DimensionIndex = 0;
            cardCompactLayoutTemplate1.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation;
            cardCompactLayoutTemplate1.BottomSubValue2.Visible = true;
            cardCompactLayoutTemplate1.BottomValue.DimensionIndex = 0;
            cardCompactLayoutTemplate1.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue;
            cardCompactLayoutTemplate1.BottomValue.Visible = true;
            cardCompactLayoutTemplate1.DeltaIndicator.Visible = true;
            cardCompactLayoutTemplate1.MainValue.DimensionIndex = 0;
            cardCompactLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title;
            cardCompactLayoutTemplate1.MainValue.Visible = true;
            cardCompactLayoutTemplate1.MaxWidth = 150;
            cardCompactLayoutTemplate1.MinWidth = 125;
            cardCompactLayoutTemplate1.Sparkline.Visible = true;
            cardCompactLayoutTemplate1.SubValue.DimensionIndex = 0;
            cardCompactLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle;
            cardCompactLayoutTemplate1.SubValue.Visible = true;
            card1.LayoutTemplate = cardCompactLayoutTemplate1;
            card1.AddDataItem("ActualValue", measure3);
            card1.AddDataItem("TargetValue", measure4);
            this.cardDashboardItem1.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1});
            this.cardDashboardItem1.ComponentName = "cardDashboardItem1";
            dimension4.DataMember = "SalesPerson";
            dimension5.DataMember = "OrderDate";
            dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.cardDashboardItem1.DataItemRepository.Clear();
            this.cardDashboardItem1.DataItemRepository.Add(measure4, "DataItem0");
            this.cardDashboardItem1.DataItemRepository.Add(measure3, "DataItem1");
            this.cardDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3");
            this.cardDashboardItem1.DataItemRepository.Add(dimension5, "DataItem2");
            this.cardDashboardItem1.DataSource = this.dashboardExtractDataSource1;
            this.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardDashboardItem1.Name = "Cards 1";
            this.cardDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.cardDashboardItem1.ShowCaption = true;
            this.cardDashboardItem1.SparklineArgument = dimension5;
            // 
            // SalesDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExtractDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pivotDashboardItem1,
            this.chartDashboardItem1,
            this.cardDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem1.Weight = 50D;
            dashboardLayoutItem2.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem2.Weight = 50D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 50D;
            dashboardLayoutItem3.DashboardItem = this.cardDashboardItem1;
            dashboardLayoutItem3.Weight = 50D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardExtractDataSource dashboardExtractDataSource1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.CardDashboardItem cardDashboardItem1;
    }
}
