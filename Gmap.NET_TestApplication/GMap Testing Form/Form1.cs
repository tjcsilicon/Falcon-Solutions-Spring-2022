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

        private double _latitude;
        private double _longitude;

        public TestingFormApplication()
        {
            InitializeComponent();
        }

        private void TestingFormApplication_Load(object sender, EventArgs e)
        {
            gMapControl.ShowCenter = false;
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            UpdatePosition(0, 0);
        }

        private void UpdatePosButton_Click(object sender, EventArgs e)
        {
            UpdatePosition(_latitude, _longitude);
        }

        public void UpdatePosition(double _x, double _y)
        {
            gMapControl.Position = new GMap.NET.PointLatLng(_x, _y);
            latitude_label.Text = "Lat: " + _x.ToString();
            longitude_label.Text = "Lng: " + _y.ToString();
        }

        private void Pos_x_field_TextChanged(object sender, EventArgs e)
        {
            string str = pos_x_field.Text;
            if (isDouble(str))
            {
                updatePosButton.Enabled = true;
                _latitude = Convert.ToDouble(pos_x_field.Text);
            } else
            {
                updatePosButton.Enabled = false;
            }
        }

        private void Pos_y_field_TextChanged(object sender, EventArgs e)
        {
            string str = pos_y_field.Text;
            if (isDouble(str))
            {
                updatePosButton.Enabled = true;
                _longitude = Convert.ToDouble(pos_y_field.Text);
            }
            else
            {
                updatePosButton.Enabled = false;
            }
        }

        private bool isDouble(string _s)
        {
            double test;
            if(Double.TryParse(_s, out test))
            {
                return true;
            } return false;
        } 
    }
}
