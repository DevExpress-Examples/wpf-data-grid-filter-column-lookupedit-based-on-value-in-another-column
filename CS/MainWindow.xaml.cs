using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace WPFDataGridApp13 {
    public partial class MainWindow : Window {
        LookUpEditBase Editor;

        public ObservableCollection<City> Cities { get; private set; }
        public ObservableCollection<Country> Countries { get; private set; }
        public ObservableCollection<SampleData> Data { get; private set; }

        public MainWindow() {
            Countries = new ObservableCollection<Country>();
            Cities = new ObservableCollection<City>();
            Data = new ObservableCollection<SampleData>();

            GenerateData();
            DataContext = this;

            InitializeComponent();
        }

        void GenerateData() {
            Countries.Add(new Country() { CountryId = 0, CountryName = "USA" });
            Countries.Add(new Country() { CountryId = 1, CountryName = "Russia" });
            Countries.Add(new Country() { CountryId = 2, CountryName = "Germany" });

            Cities.Add(new City() { CityId = 0, CityName = "Washington, D.C.", CountryId = 0 });
            Cities.Add(new City() { CityId = 1, CityName = "New York", CountryId = 0 });
            Cities.Add(new City() { CityId = 2, CityName = "Los Angeles", CountryId = 0 });
            Cities.Add(new City() { CityId = 3, CityName = "Las Vegas", CountryId = 0 });

            Cities.Add(new City() { CityId = 4, CityName = "Moscow", CountryId = 1 });
            Cities.Add(new City() { CityId = 5, CityName = "Saint-Petersburg", CountryId = 1 });

            Cities.Add(new City() { CityId = 6, CityName = "Berlin", CountryId = 2 });
            Cities.Add(new City() { CityId = 7, CityName = "Munich", CountryId = 2 });
            Cities.Add(new City() { CityId = 8, CityName = "Frankfurt", CountryId = 2 });

            Data.Add(new SampleData() { CountryId = 0, CityId = 1 });
            Data.Add(new SampleData() { CountryId = 2, CityId = 7 });
            Data.Add(new SampleData() { CountryId = 2, CityId = 6 });
            Data.Add(new SampleData() { CountryId = 1, CityId = 4 });
            Data.Add(new SampleData() { CountryId = 0, CityId = 3 });
            Data.Add(new SampleData() { CountryId = 1, CityId = 5 });
        }

        void OnTableViewShownEditor(object sender, EditorEventArgs e) {
            if (e.Column.FieldName != "CityId")
                return;
            Editor = e.Editor as LookUpEditBase;
            if (Editor == null)
                return;
            TableView view = (TableView)sender;
            int countryId = (int)view.Grid.GetCellValue(e.RowHandle, "CountryId");
            Editor.ItemsSource = Cities.Where(city => city.CountryId == countryId).ToList();
        }

        void TableVieHiddenEditor(object sender, EditorEventArgs e) {
            if (Editor == null)
                return;
            Editor.ItemsSource = Cities;
            Editor = null;
        }

        void TableViewCellValueChanged(object sender, CellValueChangedEventArgs e) {
            if (e.Column.FieldName == "CountryId") {
                SampleData sd = e.Row as SampleData;
                sd.CityId = -1;
            }
        }
    }

    public class Country {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class City {
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
    }

    public class SampleData {
        public int CountryId { get; set; }
        public int CityId { get; set; }
    }
}