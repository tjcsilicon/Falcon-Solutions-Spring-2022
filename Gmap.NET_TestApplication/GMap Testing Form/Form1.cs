using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using GMap.NET;
using LiveCharts;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;
using Core;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsFormsApp1
{
    public partial class TestingFormApplication : Form
    {

        double _latitude; // latitude value for the gMap control
        double _longitude; // longitude value for the gMap control

        PopulationHandler m_core = new PopulationHandler();

        public TestingFormApplication(double _x, double _y) {
            m_core.GetDataset();
            InitializeComponent();
            AddPopulationToDataset();
            _latitude = _x;
            _longitude = _y;
            PopulateMap();
        }

        private void TestingFormApplication_Load(object sender, EventArgs e) {
            gMapControl.ShowCenter = false;
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl.Zoom = 13;
            gMapControl.Position = new GMap.NET.PointLatLng(_latitude, _longitude);
            InitializeChart();            
        }

        int imgSize = 32;
        private void PopulateMap()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            foreach (KeyValuePair<int, Individual> individual in m_core.population_set)
            {

                Bitmap img = new Bitmap(64, 64);
                switch(individual.Value.status)
                {
                    case IndividualStatus.susceptable:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Susceptable_large, new Size(imgSize, imgSize));
                        break;
                    case IndividualStatus.infected:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Infected_large, new Size(imgSize, imgSize));
                        break;
                    case IndividualStatus.recovered:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Recovered_large, new Size(imgSize, imgSize));
                        break;
                }
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(_latitude + offsetToLatLng(individual.Value.pos_x), _longitude + offsetToLatLng(individual.Value.pos_x)),
                    img);
                markersOverlay.Markers.Add(marker);
            }
            gMapControl.Overlays.Add(markersOverlay);
        }

        private float offsetMultiplier = 0.001f;
        public float offsetToLatLng(float offset)
        {
            return offset * offsetMultiplier;
        }

        // Initialize the LiveChart Cartesian Chart
        private void InitializeChart() {
            //StackedAreaSeries series = new StackedAreaSeries() { DataLabels = true, Values = new ChartValues<int>()};
            //Axis axis = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
            //axis.Labels = new List<string>();

            //series.Values.Add(3);
            //series.Values.Add(4);

            //data_graph.Series.Add(series);
        }

        private void Add_series_button_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            var success = form.ShowDialog();
            if(success == DialogResult.OK)
            {
                List<int> list = form.ReturnValue;

                StackedAreaSeries series = new StackedAreaSeries() { DataLabels = true, Values = new ChartValues<int>() };
                Axis axis = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                axis.Labels = new List<string>();

                foreach(int i in list)
                {
                    series.Values.Add(i);
                }

                data_graph.Series.Add(series);
            }
        }

        private void AddPopulationToDataset()
        {
            foreach(KeyValuePair<int, Individual> item in m_core.population_set)
            {
                var m_individual = item.Value;
                individual_listbox.Items.Add(m_individual.id + ": " + m_individual.lastName + ", " + m_individual.firstName);
            }
        }

        private void Individual_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            int curItem = individual_listbox.SelectedIndex;
            SetIndividualData(m_core.population_set[curItem]);
        }

        private void SetIndividualData(Individual m_data)
        {
            individual_data_connections.Items.Clear();
            individual_data_name.Text = "Individual Name: " + m_data.firstName + " " + m_data.lastName;

            string status = "";
            System.Drawing.Color color = System.Drawing.Color.Black;
            switch(m_data.status)
            {
                case IndividualStatus.susceptable:
                    color = System.Drawing.Color.ForestGreen;
                    status = "SUSCEPTABLE";
                    break;
                case IndividualStatus.infected:
                    color = System.Drawing.Color.DarkRed;
                    status = "INFECTED";
                    break;
                case IndividualStatus.recovered:
                    color = System.Drawing.Color.BlueViolet;
                    status = "RECOVERED";
                    break;
            }
            individual_data_status.ForeColor = color;
            individual_data_status.Text = status;

            for(int i = 0; i < m_data.connections.Count; i++)
            {
                individual_data_connections.Items.Add(IndividualDataConnectionString(m_data.connections[i], m_data.weights[i]));
            }
        }

        private string IndividualDataConnectionString(Individual m_obj, float m_weight)
        {
            string value = m_obj.firstName + " " + m_obj.lastName + "  ---- " + m_weight;
            return value;
        }


    }
}
