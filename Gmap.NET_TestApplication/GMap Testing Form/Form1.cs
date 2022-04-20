using System;
using System.Collections;
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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Firebase.Vaccination;

namespace WindowsFormsApp1
{
    public partial class TestingFormApplication : Form
    {

        double _latitude; // latitude value for the gMap control
        double _longitude; // longitude value for the gMap control

        Random rnd = new Random();


        public TestingFormApplication(double _x, double _y) {
            getData.Run().Wait();
            //InitializeComponent();
            //AddPopulationToDataset();
            //_latitude = _x;
            //_longitude = _y;
            //PopulateMap();
            //DrawConnections();
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
            foreach (Individual individual in getData.pop.individuals)
            {

                Bitmap img = new Bitmap(64, 64);
                switch(individual.status)
                {
                    case 0:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Susceptable_large, new Size(imgSize, imgSize));
                        break;
                    case 1:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Infected_large, new Size(imgSize, imgSize));
                        break;
                    case -1:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Recovered_large, new Size(imgSize, imgSize));
                        break;
                }
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(individual.lat, individual.lng),
                    img);
                markersOverlay.Markers.Add(marker);
            }
            gMapControl.Overlays.Add(markersOverlay);
        }

        private float offsetMultiplier = 0.001f;

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
            foreach(Individual item in getData.pop.individuals)
            {
                individual_listbox.Items.Add(item.name);
            }
        }

        private void Individual_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            int curItem = individual_listbox.SelectedIndex;
            SetIndividualData(getData.pop.individuals[curItem]);
        }

        private void SetIndividualData(Individual m_data)
        {
            individual_data_connections.Items.Clear();
            individual_data_name.Text = "Individual Name: " + m_data.name;

            string status = "";
            System.Drawing.Color color = System.Drawing.Color.Black;
            switch(m_data.status)
            {
                case 0:
                    color = System.Drawing.Color.ForestGreen;
                    status = "SUSCEPTABLE";
                    break;
                case 1:
                    color = System.Drawing.Color.DarkRed;
                    status = "INFECTED";
                    break;
                case -1:
                    color = System.Drawing.Color.BlueViolet;
                    status = "RECOVERED";
                    break;
            }
            individual_data_status.ForeColor = color;
            individual_data_status.Text = status;

            for(int i = 0; i < m_data.In.Length; i++)
            {
                individual_data_connections.Items.Add(IndividualDataConnectionString(m_data, i));
            }
        }

        private string IndividualDataConnectionString(Individual m_obj, int i)
        {
            string value = m_obj.name + "  ---- " + m_obj.In[i].w;
            return value;
        }

        int counter;
        private void simulation_update_timer_Tick(object sender, EventArgs e)
        {
            if (counter > 10) { simulation_update_timer.Enabled = false; EndSimulation(); return; }
            // generate a random value
            

            UpdateGraph(infected_series);
            UpdateGraph(susceptable_series);
            UpdateGraph(recovered_series);
            //UpdateGraph(vaccinated_series);
            counter++;
        }

        private void UpdateGraph(StackedAreaSeries m_series)
        {
            int value = rnd.Next(0, 10);
            m_series.Values.Add(value);
        }

        StackedAreaSeries susceptable_series, infected_series, recovered_series, vaccinated_series = new StackedAreaSeries();

        private void run_simulation_button_Click(object sender, EventArgs e)
        {
            BeginSimulation();
            // for testing reasons, this button just populates the graph.
            run_simulation_button.Enabled = false;
            susceptable_series = new StackedAreaSeries() { DataLabels = true, Values = new ChartValues<int>(), Fill = System.Windows.Media.Brushes.Aqua };
            infected_series = new StackedAreaSeries() { DataLabels = true, Values = new ChartValues<int>(), Fill = System.Windows.Media.Brushes.DarkRed };
            recovered_series = new StackedAreaSeries() { DataLabels = true, Values = new ChartValues<int>(), Fill = System.Windows.Media.Brushes.BlueViolet };
            vaccinated_series = new StackedAreaSeries() { DataLabels = true, Values = new ChartValues<int>(), Fill = System.Windows.Media.Brushes.LimeGreen };

            data_graph.Series.Add(susceptable_series);
            data_graph.Series.Add(infected_series);
            data_graph.Series.Add(recovered_series);
            data_graph.Series.Add(vaccinated_series);

            Axis axis = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
            axis.Labels = new List<string>();

            simulation_update_timer.Enabled = true;
        }

        private void DrawConnections()
        {
            /*GMapOverlay polyOverlay = new GMapOverlay("polygons");
            foreach (KeyValuePair<int, Individual> m_individual in m_core.population_set)
            {
                Individual person = m_individual.Value;
                foreach (Individual connection in person.connections)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(_latitude - offsetToLatLng(person.pos_x), _longitude - offsetToLatLng(person.pos_y)));
                    points.Add(new PointLatLng(_latitude - offsetToLatLng(connection.pos_x), _longitude - offsetToLatLng(connection.pos_y)));
                    GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
                    polygon.Stroke = new System.Drawing.Pen(System.Drawing.Color.Red, 1);
                    polyOverlay.Polygons.Add(polygon);

                }
            }
            gMapControl.Overlays.Add(polyOverlay);*/
        }

        private void BeginSimulation()
        {
            Log("Simulation has began running!");
        }

        private void EndSimulation()
        {
            Log("Simulation has finished succesfully!");
        }

        public void Log(string message)
        {
            outputBox.Items.Add("$ " + message);
        }
    }
}
