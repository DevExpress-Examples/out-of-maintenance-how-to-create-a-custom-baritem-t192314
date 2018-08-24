# How to create a custom BarItem


<p>BarItem is not a visual element and creating its descendant may be not sufficient if it's necessary to customize its behavior. BarItem is represented in a visual tree by BarItemLinkControl. To use a custom BarItemLinkControl, register it using the BarItemLinkControlCreator.RegisterObject method. </p>

<br/>

Please refer to the [CustomBarElements.cs](CS/WpfApplication1/CustomBarElements.cs) file to learn how to cretae an register custom bar items.
