using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Vaccination;
using Firebase.Login;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO Run an asynchronous function to check whether the visual simulation should begin or not
            Login verification = new Login();
            DataReader dataReader = new DataReader();
            RunCheck check = new RunCheck();
            //dataReader.Run().Wait();
            //Task.Run(() => verification.HandleLogin().Wait());
            Task.Run(() => dataReader.Run().Wait());
            Task.Run(() => check.Update());
            Application.Run(new LoginScreen(dataReader, verification, ref check));
        }
    }

    public class RunCheck
    {
        public bool canStart = false;
        public void Update()
        {
            bool isValidToStart = false;
            do
            {

            } while (isValidToStart == false);
            canStart = true;
        }
    }
}
