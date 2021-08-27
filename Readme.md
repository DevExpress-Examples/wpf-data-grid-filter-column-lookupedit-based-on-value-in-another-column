<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650458/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3826)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to filter a LookUpEdit in one column based on the value of another column

This example illustrates how to filter [LookUpEdit](https://docs.devexpress.com/WPF/8862/controls-and-libraries/data-editors/editor-types/lookupedit) items based on the value of another column.

To provide this functionality, we show cell editors using the [CellTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellTemplate) property. Unlike [EditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.EditSettings), this property allows you to display independent editors with different [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.ItemsSource) collections.

The **ItemsSource** collection is filtered in the [ShownEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ShownEditor) event handler and is set to its original value in the [HiddenEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.HiddenEditor) event handler.

The last step - setting **ItemsSource** to the original value - is required since **GridControl** creates visual elements only for visible rows and will re-use cell editors on scrolling rows. Since editors with the [DisplayMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.DisplayMember)/[ValueMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.ValueMember) property set show only values from the **ItemsSource** collection, values in other cells may disappear if you skip this step.
