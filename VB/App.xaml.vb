' Developer Express Code Central Example:
' How to filter a LookUpEdit in one column based on the value of another column
' 
' This example illustrates how to filter LookUpEdit item source values in one
' column based on the value of another column. This functionality can be
' implemented only when a filtered LookUpEdit is introduced using a cell template.
' In this case, every cell has an independent LookUpEdit editor, and we can
' manipulate its item source. The item source is filtered in the
' TableView.ShownEditor event handler. This event is raised when a cell gets
' focus, and its editor becomes active, so it is the best place to filter the item
' source.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3826
Imports System.Windows

Namespace WPFDataGridApp13

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

    End Class
End Namespace
