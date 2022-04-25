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
    public partial class Form2 : Form
    {

        public List<int> ReturnValue { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public List<int> intList = new List<int>();

        void AddValue(int value)
        {
            intList.Add(value);
            string label_text = "";
            foreach (int i in intList)
            {
                label_text = label_text + i + ", ";
            }
            values_label.Text = label_text;
        }

        private void Add_value_button_Click(object sender, EventArgs e)
        {
            string s = value_box.Text;
            value_box.Text = "";
            AddValue(Convert.ToInt32(s));
        }

        private void Add_series_button_Click(object sender, EventArgs e)
        {
            this.ReturnValue = intList;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
