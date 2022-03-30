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

namespace WindowsFormsApp1
{
    public partial class TestingFormApplication : Form
    {

        double _latitude; // latitude value for the gMap control
        double _longitude; // longitude value for the gMap control

        public TestingFormApplication(double _x, double _y) {
            InitializeComponent();
            _latitude = _x;
            _longitude = _y;
            PopulationHandler p = new PopulationHandler();
            p.Test();
        }

        private void TestingFormApplication_Load(object sender, EventArgs e) {
            gMapControl.ShowCenter = false;
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl.Zoom = 13;
            gMapControl.Position = new GMap.NET.PointLatLng(_latitude, _longitude);
            InitializeChart();
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
    }
}
