<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/142892281/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830552)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml.cs](./CS/Dashboard_UnderlyingDataWPF/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Dashboard_UnderlyingDataWPF/MainWindow.xaml.vb))
* [MainWindow.xaml](./CS/Dashboard_UnderlyingDataWPF/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Dashboard_UnderlyingDataWPF/MainWindow.xaml))
<!-- default file list end -->

# Dashboard for WPF - How to obtain dashboard item's underlying data when the mouse hovers over it

This example handles the [DashboardControl.DashboardItemMouseEnter](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardItemMouseEnter), [DashboardControl.DashboardItemMouseMove](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardItemMouseMove) and [DashboardControl.DashboardItemMouseLeave](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardItemMouseLeave) events to display a popup that contains a [Data Grid](https://docs.devexpress.com/WPF/6084/controls-and-libraries/data-grid) control to display item data when the mouse hovers over it. The data are obtained using the [e.GetUnderlyingData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardItemMouseActionWpfEventArgs.GetUnderlyingData) method.

![](./images/ItemDataOnMouseHover.png)


## Documentation

- [Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/400159/wpf-viewer/obtain-underlying-and-displayed-data)

## More Examples

- [How to handle a mouse click to obtain dashboard item data](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-obtain-clicked-item-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-dashboard-how-to-obtain-item-data-on-mouse-hover&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-dashboard-how-to-obtain-item-data-on-mouse-hover&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
