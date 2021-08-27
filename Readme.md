<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640725/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T192314)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomBarElements.cs](./CS/WpfApplication1/CustomBarElements.cs) (VB: [CustomBarElements.vb](./VB/WpfApplication1/CustomBarElements.vb))
* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create a custom BarItem


<p>BarItem is not a visual element and creating its descendant may be not sufficient if it's necessary to customize its behavior. BarItem is represented in a visual tree by BarItemLinkControl. To use a custom BarItemLinkControl, register it using the BarItemLinkControlCreator.RegisterObject method. </p>

<br/>

Please refer to the [CustomBarElements.cs](CS/WpfApplication1/CustomBarElements.cs) file to learn how to create an register custom bar items.
