using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace DAQSimulation
{
    public partial class Form1 : Form
    {
        //public Operation operation;
        double timeLeft;
        double logtimeLeft;
        bool first = true;
        bool clearSensorText = false;
        Sensor[] sObj = new Sensor[4]; //Max amount of sensors

        public Form1()
        {
            InitializeComponent();
            loggingBox.Text = "0 sec";
            samplingBox.Text = "0 sec";
            timer1.Interval = 100;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            samplingTimer.Interval = 100;
            samplingTimer.Start();

            if(clearSensorText == true)
            {
                sensorDisplay.Text = String.Empty;
            }

            
            timeLeft = Convert.ToDouble(smplTime.Text);
            int maxSid = Convert.ToInt32(nmbSensors.Value); string sTxt;// Create an array of sensor objects
            
                if(first == true)
                {
                  
                    for (int counter = 0; counter < maxSid; counter++)
                    {
                        sObj[counter] = new Sensor(counter + 1, Convert.ToInt32(maxVolt.Value), Convert.ToInt32(minVolt.Value)); //create sensors with seed values
                    }
                    // Get the sensor object values as a string
                    for (int id = 0; id < maxSid; id++)
                    {
                        sTxt = sObj[id].GetValue().ToString("0.00");
                        sensorDisplay.Text += sTxt + "V,";
                    }
            }
                else
                {
                    // Get the sensor object values as a string
                    for (int id = 0; id < maxSid; id++)
                         {
                             sTxt = sObj[id].GetValue().ToString("0.00");
                             sensorDisplay.Text += sTxt + "V,";
                         }
                }
            first = false;
            clearSensorText = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loggingButton_Click(object sender, EventArgs e)
        {
            logtimeLeft = Convert.ToDouble(logTime.Text);
            loggingTimer.Interval = 100;
            loggingTimer.Start();
            DateTime now = DateTime.Now;
            StreamWriter sw = new StreamWriter(pathBox.Text, true);
            sw.WriteLine(Convert.ToString(now) + "," + sensorDisplay.Text);
            sw.Close();
            clearSensorText = true;
        }

        private void samplingTimer_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                samplingBox.Text = Math.Round(timeLeft, 1) + " sec";
                timeLeft = timeLeft - 0.1f;
                samplingButton.Enabled = false;
            }
            else
            {
                samplingTimer.Stop();
                samplingBox.Text = "0 sec";
                samplingButton.Enabled = true;
            }
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please input certain parameters");
        }

        private void operationMenu_Click(object sender, EventArgs e)
        {
            //operation.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void writeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try {
                StreamReader sr = new StreamReader(pathBox.Text);
                readBox.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Please choose valid file");
            }

        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            pathBox.Text = of.FileName;
        }

        private void loggingTimer_Tick(object sender, EventArgs e)
        {
            if (logtimeLeft > 0)
            {
                loggingBox.Text = Math.Round(logtimeLeft, 1) + " sec";
                logtimeLeft = logtimeLeft - 0.1f;
                loggingButton.Enabled = false;
            }
            else
            {
                loggingTimer.Stop();
                loggingBox.Text = "0 sec";
                loggingButton.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
