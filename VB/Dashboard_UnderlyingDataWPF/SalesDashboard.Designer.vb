Namespace Dashboard_UnderlyingDataWPF
    Partial Public Class SalesDashboard
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.dashboardExtractDataSource1 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pivotDashboardItem1
            ' 
            dimension1.DataMember = "OrderDate"
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            measure1.DataMember = "ExtendedPrice"
            dimension2.DataMember = "CategoryName"
            dimension3.DataMember = "ProductName"
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem3")
            Me.pivotDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
            Me.pivotDashboardItem1.Name = "Pivot 1"
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2, dimension3})
            Me.pivotDashboardItem1.ShowCaption = False
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
            ' 
            ' dashboardExtractDataSource1
            ' 
            Me.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1"
            Me.dashboardExtractDataSource1.FileName = "|DataDirectory|\Data\NWind_SalesPerson.dat"
            Me.dashboardExtractDataSource1.Name = "Extract Data Source 1"
            ' 
            ' chartDashboardItem1
            ' 
            dimension4.DataMember = "OrderDate"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure2.DataMember = "ExtendedPrice"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1")
            Me.chartDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Chart 1"
            chartPane1.Name = "Pane 1"
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.PrimaryAxisY.ShowGridLines = True
            chartPane1.PrimaryAxisY.TitleVisible = True
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.SecondaryAxisY.ShowGridLines = False
            chartPane1.SecondaryAxisY.TitleVisible = True
            simpleSeries1.AddDataItem("Value", measure2)
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
            Me.chartDashboardItem1.ShowCaption = False
            ' 
            ' gridDashboardItem1
            ' 
            dimension5.DataMember = "SalesPerson"
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension5)
            measure3.DataMember = "ExtendedPrice"
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure3)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0")
            Me.gridDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = False
            ' 
            ' SalesDashboard
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExtractDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotDashboardItem1, Me.gridDashboardItem1, Me.chartDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pivotDashboardItem1
            dashboardLayoutItem1.Weight = 49.921752738654149R
            dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem2.Weight = 49.876543209876544R
            dashboardLayoutItem3.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem3.Weight = 50.123456790123456R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem2, dashboardLayoutItem3})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            dashboardLayoutGroup2.Weight = 50.078247261345851R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutGroup2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private dashboardExtractDataSource1 As DevExpress.DashboardCommon.DashboardExtractDataSource
        Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
    End Class
End Namespace
