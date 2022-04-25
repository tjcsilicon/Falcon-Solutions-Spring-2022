﻿using System;
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

using MColor = System.Windows.Media.Color;
using DColor = System.Drawing.Color;


namespace WindowsFormsApp1
{
    public partial class MainSimulation : Form
    {

        double _latitude = 46.277807; // latitude value for the gMap control
        double _longitude = -119.274558; // longitude value for the gMap control

        DataReader dataReader;
        Random rnd = new Random(); // can remove on publication
        Population pop;
        RunCheck server_check;

        public MainSimulation(DataReader _dataset, ref RunCheck _check) {
            //dataset.Run().Wait();
            dataReader = _dataset;
            server_check = _check;
            pop = dataReader.population_dataset;
            InitializeComponent();
            Log("UI Components have been initialized");
            AddPopulationToDataset();
            Log("Population has been imported into the system");
            PopulateMap();
            Log("GMap Interface has been populated with nodes");
            DrawConnections();
            Log("Gmap interface Nodes have had connections drawn");
        }

        public int[] recipients;
        public int virusStart;

        public void HandleVaccines()
        {
            VaccinationAssessment vaccinationAssessment = new VaccinationAssessment(pop);
        }

        private void TestingFormApplication_Load(object sender, EventArgs e) {
            gMapControl.ShowCenter = false;
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl.Zoom = 13;
            gMapControl.Position = new GMap.NET.PointLatLng(_latitude, _longitude);
            InitializeChart();
            Log("EISS initialized");
        }

        // Populate the map with the icons representing individuals
        int imgSize = 32;
        private void PopulateMap()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            foreach (Individual individual in pop.individuals)
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
            foreach(Individual item in pop.individuals)
            {
                individual_listbox.Items.Add(item.name);
            }
        }

        private void Individual_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            int curItem = individual_listbox.SelectedIndex;
            SetIndividualData(pop.individuals[curItem]);
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
            string value = pop.individuals[m_obj.In[i].id].name + "  ---- " + m_obj.In[i].w;
            return value;
        }

        int counter;

        // Update the UI|| Change to be called from thread in simulation class
        private void simulation_update_timer_Tick(object sender, EventArgs e)
        {
            if (counter > 10) { simulation_update_timer.Enabled = false; EndSimulation(); return; }
            // generate a random value

          //  gMapControl.Overlays.Remove(polyOverlay);
            UpdateGraph(infected_series);
            UpdateGraph(susceptable_series);
            UpdateGraph(recovered_series);
            DrawConnections();
            //UpdateGraph(vaccinated_series);
            counter++;
        }

        public IEnumerator e()
        {
            yield return new 
        }

        private void UpdateGraph(StackedAreaSeries m_series)
        {
            int value = rnd.Next(0, 10);
            m_series.Values.Add(value);
        }

        StackedAreaSeries susceptable_series, infected_series, recovered_series, vaccinated_series = new StackedAreaSeries();

        // Testing only, run the dummy simulation
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

        GMapOverlay polyOverlay = new GMapOverlay("polygons");

        // Draw a line between each of the connections in the population
        private void DrawConnections()
        {
            gMapControl.Overlays.Remove(polyOverlay);
            polyOverlay.Clear();
            int indv = 0;
            foreach (Individual m_individual in pop.individuals)
            {
                int id = 0;
                foreach (var connection in m_individual.In)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(m_individual.lat, m_individual.lng));
                    points.Add(new PointLatLng(pop.individuals[connection.id].lat, pop.individuals[connection.id].lng));
                    GMapPolygon polygon = new GMapPolygon(points, "mypolygon");

                    DColor color = GetColorOfLine(indv, id);

                    polygon.Stroke = new System.Drawing.Pen(color, 0.5f);
                    polyOverlay.Polygons.Add(polygon);
                    id++;

                }
                indv++;
            }
            gMapControl.Overlays.Add(polyOverlay);
        }

        private System.Drawing.Color GetColorOfLine(int person_a, int id)
        {
            if(pop.individuals[person_a].In[id].infectTrigger)
            {
                return System.Drawing.Color.Red;
            } else
            {
                return DColor.FromArgb(100, 37, 70, 74);
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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