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
            Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim measure4 As New DevExpress.DashboardCommon.Measure()
            Dim card1 As New DevExpress.DashboardCommon.Card()
            Dim cardCompactLayoutTemplate1 As New DevExpress.DashboardCommon.CardCompactLayoutTemplate()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.dashboardExtractDataSource1 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pivotDashboardItem1
            ' 
            dimension1.DataMember = "OrderDate"
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            measure1.DataMember = "ExtendedPrice"
            dimension2.DataMember = "CategoryName"
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2")
            Me.pivotDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
            Me.pivotDashboardItem1.Name = "Pivot 1"
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.pivotDashboardItem1.ShowCaption = False
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
            ' 
            ' dashboardExtractDataSource1
            ' 
            calculatedField1.Expression = "[Quantity] * [UnitPrice]"
            calculatedField1.Name = "RegularPrice"
            Me.dashboardExtractDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1})
            Me.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1"
            Me.dashboardExtractDataSource1.FileName = "|DataDirectory|\Data\NWind_SalesPerson.dat"
            Me.dashboardExtractDataSource1.Name = "Extract Data Source 1"
            ' 
            ' chartDashboardItem1
            ' 
            dimension3.DataMember = "OrderDate"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure2.DataMember = "ExtendedPrice"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
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
            ' cardDashboardItem1
            ' 
            measure3.DataMember = "ExtendedPrice"
            measure4.DataMember = "RegularPrice"
            card1.DeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 5, 0, 0, 0})
            card1.LayoutDeltaOptions.ResultIndicationThreshold = New Decimal(New Integer() { 5, 0, 0, 0})
            cardCompactLayoutTemplate1.BottomSubValue1.DimensionIndex = 0
            cardCompactLayoutTemplate1.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            cardCompactLayoutTemplate1.BottomSubValue1.Visible = True
            cardCompactLayoutTemplate1.BottomSubValue2.DimensionIndex = 0
            cardCompactLayoutTemplate1.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            cardCompactLayoutTemplate1.BottomSubValue2.Visible = True
            cardCompactLayoutTemplate1.BottomValue.DimensionIndex = 0
            cardCompactLayoutTemplate1.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            cardCompactLayoutTemplate1.BottomValue.Visible = True
            cardCompactLayoutTemplate1.DeltaIndicator.Visible = True
            cardCompactLayoutTemplate1.MainValue.DimensionIndex = 0
            cardCompactLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            cardCompactLayoutTemplate1.MainValue.Visible = True
            cardCompactLayoutTemplate1.MaxWidth = 150
            cardCompactLayoutTemplate1.MinWidth = 125
            cardCompactLayoutTemplate1.Sparkline.Visible = True
            cardCompactLayoutTemplate1.SubValue.DimensionIndex = 0
            cardCompactLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            cardCompactLayoutTemplate1.SubValue.Visible = True
            card1.LayoutTemplate = cardCompactLayoutTemplate1
            card1.AddDataItem("ActualValue", measure3)
            card1.AddDataItem("TargetValue", measure4)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension4.DataMember = "SalesPerson"
            dimension5.DataMember = "OrderDate"
            dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(measure4, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension5, "DataItem2")
            Me.cardDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.cardDashboardItem1.Name = "Cards 1"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
            Me.cardDashboardItem1.ShowCaption = True
            Me.cardDashboardItem1.SparklineArgument = dimension5
            ' 
            ' SalesDashboard
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExtractDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotDashboardItem1, Me.chartDashboardItem1, Me.cardDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem1.Weight = 50R
            dashboardLayoutItem2.DashboardItem = Me.pivotDashboardItem1
            dashboardLayoutItem2.Weight = 50R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Weight = 50R
            dashboardLayoutItem3.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem3.Weight = 50R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private dashboardExtractDataSource1 As DevExpress.DashboardCommon.DashboardExtractDataSource
        Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
    End Class
End Namespace
