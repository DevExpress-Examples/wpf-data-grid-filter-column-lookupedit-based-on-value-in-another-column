Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Windows

Namespace WPFDataGridApp13
    Partial Public Class MainWindow
        Inherits Window

        Private Editor As LookUpEditBase

        Public Property Cities() As ObservableCollection(Of City)
        Public Property Countries() As ObservableCollection(Of Country)
        Public Property Data() As ObservableCollection(Of SampleData)

        Public Sub New()
            Countries = New ObservableCollection(Of Country)()
            Cities = New ObservableCollection(Of City)()
            Data = New ObservableCollection(Of SampleData)()

            GenerateData()
            DataContext = Me

            InitializeComponent()
        End Sub

        Private Sub GenerateData()
            Countries.Add(New Country() With {.CountryId = 0, .CountryName = "USA"})
            Countries.Add(New Country() With {.CountryId = 1, .CountryName = "Russia"})
            Countries.Add(New Country() With {.CountryId = 2, .CountryName = "Germany"})

            Cities.Add(New City() With {.CityId = 0, .CityName = "Washington, D.C.", .CountryId = 0})
            Cities.Add(New City() With {.CityId = 1, .CityName = "New York", .CountryId = 0})
            Cities.Add(New City() With {.CityId = 2, .CityName = "Los Angeles", .CountryId = 0})
            Cities.Add(New City() With {.CityId = 3, .CityName = "Las Vegas", .CountryId = 0})

            Cities.Add(New City() With {.CityId = 4, .CityName = "Moscow", .CountryId = 1})
            Cities.Add(New City() With {.CityId = 5, .CityName = "Saint-Petersburg", .CountryId = 1})

            Cities.Add(New City() With {.CityId = 6, .CityName = "Berlin", .CountryId = 2})
            Cities.Add(New City() With {.CityId = 7, .CityName = "Munich", .CountryId = 2})
            Cities.Add(New City() With {.CityId = 8, .CityName = "Frankfurt", .CountryId = 2})

            Data.Add(New SampleData() With {.CountryId = 0, .CityId = 1})
            Data.Add(New SampleData() With {.CountryId = 2, .CityId = 7})
            Data.Add(New SampleData() With {.CountryId = 2, .CityId = 6})
            Data.Add(New SampleData() With {.CountryId = 1, .CityId = 4})
            Data.Add(New SampleData() With {.CountryId = 0, .CityId = 3})
            Data.Add(New SampleData() With {.CountryId = 1, .CityId = 5})
        End Sub

        Private Sub OnTableViewShownEditor(ByVal sender As Object, ByVal e As EditorEventArgs)
            If e.Column.FieldName <> "CityId" Then
                Return
            End If
            Editor = TryCast(e.Editor, LookUpEditBase)
            If Editor Is Nothing Then
                Return
            End If
            Dim view As TableView = DirectCast(sender, TableView)
            Dim countryId As Integer = CInt((view.Grid.GetCellValue(e.RowHandle, "CountryId")))
            Editor.ItemsSource = Cities.Where(Function(city) city.CountryId = countryId).ToList()
        End Sub

        Private Sub TableVieHiddenEditor(ByVal sender As Object, ByVal e As EditorEventArgs)
            If Editor Is Nothing Then
                Return
            End If
            Editor.ItemsSource = Cities
            Editor = Nothing
        End Sub

        Private Sub TableViewCellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
            If e.Column.FieldName = "CountryId" Then
                Dim sd As SampleData = TryCast(e.Row, SampleData)
                sd.CityId = -1
            End If
        End Sub
    End Class

    Public Class Country
        Public Property CountryId() As Integer
        Public Property CountryName() As String
    End Class

    Public Class City
        Public Property CountryId() As Integer
        Public Property CityId() As Integer
        Public Property CityName() As String
    End Class

    Public Class SampleData
        Public Property CountryId() As Integer
        Public Property CityId() As Integer
    End Class
End Namespace