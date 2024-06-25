<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650458/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3826)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Filter a Column's LookUpEdit Based on the Value in Another Column

This example filters the **City** column's [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit) items based on the **Country** column's value.

![image](https://user-images.githubusercontent.com/65009440/221793871-66b79651-c777-4314-971c-416686a331d6.png)

The [CellEditTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellEditTemplate) property allows you to display independent editors with different [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.ItemsSource) collections. The **ItemsSource** collection is filtered in the [ShownEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ShownEditor) event handler.

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

## Documentation

* [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)
* [Assign Editors to Cells](https://docs.devexpress.com/WPF/401011/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/assign-an-editor-to-a-cell)
* [ShownEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ShownEditor)
* [CellValueChanged](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.CellValueChanged)

## More Examples

* [WPF Data Grid - Use Custom Editors to Edit Cell Values](https://github.com/DevExpress-Examples/wpf-data-grid-use-custom-editors-to-edit-cell-values)
* [WPF LookUpEdit - Customize the Embedded Data Grid](https://github.com/DevExpress-Examples/wpf-lookupedit-customize-the-embedded-data-grid)
* [WPF LookUpEdit - Display a TreeList as Popup Content](https://github.com/DevExpress-Examples/wpf-lookupedit-display-treelist-as-popup-content)
* [WPF LookUpEdit - Process New Values](https://github.com/DevExpress-Examples/lookupedit-processing-new-values-e2646)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-filter-column-lookupedit-based-on-value-in-another-column&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-filter-column-lookupedit-based-on-value-in-another-column&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
