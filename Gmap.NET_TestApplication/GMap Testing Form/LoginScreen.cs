using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Vaccination;
using Firebase.Login;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {

        DataReader data;
        RunCheck running_task;
        Login verify;

        public LoginScreen(DataReader r, Login ve, ref RunCheck task)
        {
            verify = ve;
            data = r;
            running_task = task;

            InitializeComponent();
            WaitForLogin(beginButton);
        }

        void WaitForLogin(Button b)
        {
            while(!data.isReady)
            {
                b.Enabled = false;
            }
            b.Enabled = true;
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            verify.HandleLogin(textBox1.Text, maskedTextBox1.Text).Wait();
            if (verify.message == "V")
            {
                MainSimulation form = new MainSimulation(data, ref running_task);
                this.Hide();
                form.ShowDialog();
                this.Close();
            } else
            {
                label4.Visible = true;
            }
        }

        private void SetInitialPosition_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
