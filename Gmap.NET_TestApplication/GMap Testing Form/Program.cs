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
            RunCheck check = new RunCheck();
            Task.Run(() => check.Update());
            Application.Run(new SetInitialPosition(dataReader, ref check));
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
