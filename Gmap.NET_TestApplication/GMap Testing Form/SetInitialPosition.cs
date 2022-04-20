using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetInitialPosition : Form
    {

        private double _latitude;
        private double _longitude;

        public SetInitialPosition()
        {
            InitializeComponent();
        }

/*        private void Pos_x_field_TextChanged(object sender, EventArgs e)
        {
            string str = pos_x_field.Text;
            if (isDouble(str))
            {
                beginButton.Enabled = true;
                _latitude = Convert.ToDouble(pos_x_field.Text);
            }
            else
            {
                beginButton.Enabled = false;
            }
        }

        private void Pos_y_field_TextChanged(object sender, EventArgs e)
        {
            string str = pos_y_field.Text;
            if (isDouble(str))
            {
                beginButton.Enabled = true;
                _longitude = Convert.ToDouble(pos_y_field.Text);
            }
            else
            {
                beginButton.Enabled = false;
            }
        }*/

        private void TestingFormApplication_Load(object sender, EventArgs e)
        {
            //gMapControl.ShowCenter = false;
            //gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            UpdatePosition(0, 0);
        }

        public void UpdatePosition(double _x, double _y)
        {
            //gMapControl.Position = new GMap.NET.PointLatLng(_x, _y);
            //latitude_label.Text = "Lat: " + _x.ToString();
            //longitude_label.Text = "Lng: " + _y.ToString();
            _latitude = _x;
            _longitude = _y;
        }

        public static bool isDouble(string _s)
        {
            double test;
            if (Double.TryParse(_s, out test))
            {
                return true;
            }
            return false;
        }

        public static bool isInt(string _s)
        {
            int test;
            if (Int32.TryParse(_s, out test))
            {
                return true;
            }
            return false;
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            UpdatePosition(_latitude, _longitude);
       //     _latitude = default_x;
         //   _longitude = default_y;
            //TestingFormApplication form = new TestingFormApplication(_latitude, _longitude);
            this.Hide();
            //form.ShowDialog();
            this.Close();
        }

        private void SetInitialPosition_Load(object sender, EventArgs e)
        {

        }
    }
}
