<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to filter a LookUpEdit in one column based on the value of another column


<p>This example illustrates how to filter LookUpEdit item source values in one column based on the value of another column. This functionality can be implemented only when a filtered LookUpEdit is introduced using a <strong>cell template</strong>. In this case, every cell has an independent LookUpEdit editor, and we can manipulate its item source. The item source is filtered in the <strong>TableView.ShownEditor</strong> event handler. This event is raised when a cell gets focus, and its editor becomes active, so it is the best place to filter the item source.</p>

<br/>


