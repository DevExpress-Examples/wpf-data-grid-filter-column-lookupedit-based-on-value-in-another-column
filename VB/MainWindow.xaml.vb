Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Windows

Namespace WPFDataGridApp13
	Partial Public Class MainWindow
		Inherits Window

		Private privateCities As ObservableCollection(Of City)
		Public Property Cities() As ObservableCollection(Of City)
			Get
				Return privateCities
			End Get
			Private Set(ByVal value As ObservableCollection(Of City))
				privateCities = value
			End Set
		End Property
		Private privateCountries As ObservableCollection(Of Country)
		Public Property Countries() As ObservableCollection(Of Country)
			Get
				Return privateCountries
			End Get
			Private Set(ByVal value As ObservableCollection(Of Country))
				privateCountries = value
			End Set
		End Property
		Private privateData As ObservableCollection(Of SampleData)
		Public Property Data() As ObservableCollection(Of SampleData)
			Get
				Return privateData
			End Get
			Private Set(ByVal value As ObservableCollection(Of SampleData))
				privateData = value
			End Set
		End Property

		Public Sub New()
			Countries = New ObservableCollection(Of Country)()
			Cities = New ObservableCollection(Of City)()
			Data = New ObservableCollection(Of SampleData)()

			GenerateData()
			DataContext = Me

			InitializeComponent()
		End Sub

		Private Sub GenerateData()
			Countries.Add(New Country() With {
				.CountryId = 0,
				.CountryName = "USA"
			})
			Countries.Add(New Country() With {
				.CountryId = 1,
				.CountryName = "Russia"
			})
			Countries.Add(New Country() With {
				.CountryId = 2,
				.CountryName = "Germany"
			})

			Cities.Add(New City() With {
				.CityId = 0,
				.CityName = "Washington, D.C.",
				.CountryId = 0
			})
			Cities.Add(New City() With {
				.CityId = 1,
				.CityName = "New York",
				.CountryId = 0
			})
			Cities.Add(New City() With {
				.CityId = 2,
				.CityName = "Los Angeles",
				.CountryId = 0
			})
			Cities.Add(New City() With {
				.CityId = 3,
				.CityName = "Las Vegas",
				.CountryId = 0
			})

			Cities.Add(New City() With {
				.CityId = 4,
				.CityName = "Moscow",
				.CountryId = 1
			})
			Cities.Add(New City() With {
				.CityId = 5,
				.CityName = "Saint-Petersburg",
				.CountryId = 1
			})

			Cities.Add(New City() With {
				.CityId = 6,
				.CityName = "Berlin",
				.CountryId = 2
			})
			Cities.Add(New City() With {
				.CityId = 7,
				.CityName = "Munich",
				.CountryId = 2
			})
			Cities.Add(New City() With {
				.CityId = 8,
				.CityName = "Frankfurt",
				.CountryId = 2
			})

			Data.Add(New SampleData() With {
				.CountryId = 0,
				.CityId = 1
			})
			Data.Add(New SampleData() With {
				.CountryId = 2,
				.CityId = 7
			})
			Data.Add(New SampleData() With {
				.CountryId = 2,
				.CityId = 6
			})
			Data.Add(New SampleData() With {
				.CountryId = 1,
				.CityId = 4
			})
			Data.Add(New SampleData() With {
				.CountryId = 0,
				.CityId = 3
			})
			Data.Add(New SampleData() With {
				.CountryId = 1,
				.CityId = 5
			})
		End Sub

		Private Sub OnTableViewShownEditor(ByVal sender As Object, ByVal e As EditorEventArgs)
			If e.Column.FieldName <> "CityId" Then
				Return
			End If
			Dim editor As LookUpEditBase = TryCast(e.Editor, LookUpEditBase)
			If editor Is Nothing Then
				Return
			End If
			Dim view As TableView = CType(e.Source, TableView)
			Dim countryId As Integer = DirectCast(view.Grid.GetCellValue(e.RowHandle, "CountryId"), Integer)
			editor.ItemsSource = Cities.Where(Function(city) city.CountryId = countryId).ToList()
		End Sub

		Private Sub TableViewCellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
			If e.Column.FieldName = "CountryId" Then
				Dim sd As SampleData = DirectCast(e.Row, SampleData)
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