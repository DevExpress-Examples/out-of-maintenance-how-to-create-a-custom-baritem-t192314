<!-- default file list -->
*Files to look at*:

* [CustomBarElements.cs](./CS/WpfApplication1/CustomBarElements.cs) (VB: [CustomBarElements.vb](./VB/WpfApplication1/CustomBarElements.vb))
* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create a custom BarItem


<p>BarItem is not a visual element and creating its descendant may be not sufficient if it's necessary to customize its behavior. BarItem is represented in a visual tree by BarItemLinkControl. To use a custom BarItemLinkControl, register it using the BarItemLinkControlCreator.RegisterObject method. </p>

<br/>

Please refer to the [CustomBarElements.cs](CS/WpfApplication1/CustomBarElements.cs) file to learn how to cretae an register custom bar items.
