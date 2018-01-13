using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQSimulation
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
            Application.Run(new Form1());
            /*
            int counter, maxSid = 16; string sTxt;// Create an array of sensor objects
            Sensor[] sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++){
                sObj[counter] = new Sensor(counter, 5, 0);
            }// Get the object values as a string
            for (counter = 0; counter < maxSid; counter++)
            {
                sTxt = sObj[counter].GetValueAI().ToString("F3");
                Console.Write(sTxt);
            }*/
        }
    }
}
