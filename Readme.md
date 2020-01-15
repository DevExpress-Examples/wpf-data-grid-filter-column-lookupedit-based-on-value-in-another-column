<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to filter a LookUpEdit in one column based on the value of another column

This example illustrates how to filter [LookUpEdit](https://docs.devexpress.com/WPF/8862/controls-and-libraries/data-editors/editor-types/lookupedit) items based on the value in another column.

To provide this functionality, we specify cell editors using the [CellEditTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellEditTemplate) property. Unlike [EditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.EditSettings), this property allows you to display independent editors with different [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.ItemsSource) collections.

The **ItemsSource** collection is filtered in the [ShownEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ShownEditor) event handler.
