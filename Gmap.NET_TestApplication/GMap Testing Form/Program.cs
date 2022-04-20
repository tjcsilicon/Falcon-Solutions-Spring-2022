using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Vaccination;

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

            DataReader dataReader = new DataReader();
            dataReader.Run().Wait();
            Application.Run(new TestingFormApplication(dataReader));
        }
    }
}
