using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace WindowsFormsApp1
{
    public partial class TestingFormApplication : Form
    {

        double _latitude;
        double _longitude;

        public TestingFormApplication(double _x, double _y)
        {
            InitializeComponent();
            _latitude = _x;
            _longitude = _y;
        }

        private void TestingFormApplication_Load(object sender, EventArgs e)
        {
            gMapControl.ShowCenter = false;
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl.Zoom = 13;
            gMapControl.Position = new GMap.NET.PointLatLng(_latitude, _longitude);
            
        }
    }
}
