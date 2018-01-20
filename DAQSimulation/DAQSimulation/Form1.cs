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
        Sensor[] sObj = new Sensor[16]; //Max amount of sensors
        Filter[] fObj = new Filter[16]; 

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
            sample();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loggingButton_Click(object sender, EventArgs e)
        {
            log();
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
                if( autoSampling.Checked == true){
                    sample();
                }
            }
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app simulates a DAQ device with a specified input range and sampling time. The app can log the data to a file in CSV format with a specified interval. " +
                "Please input a value for all the parameters", "Input Information", System.Windows.Forms.MessageBoxButtons.OK);
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
                if(autoLogging.Checked == true)
                {
                    log();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void sample()
        {
            samplingTimer.Interval = 100;
            samplingTimer.Start();

            if (clearSensorText == true)
            {
                sensorDisplay.Text = String.Empty;
            }


            timeLeft = Convert.ToDouble(smplTime.Text);

            int maxDI = Convert.ToInt32(nmbDI.Value);
            int maxAI = Convert.ToInt32(nmbSensors.Value);
            int maxSid = maxDI + maxAI; string sTxt;// Create an array of sensor objects

            //Add timestamp
            DateTime now = DateTime.Now;

            //Get AI sensor values
            if (first == true)
            {

                for (int counter = 0; counter < maxSid; counter++) //Create objects
                {
                    sObj[counter] = new Sensor(counter + 1, Convert.ToInt32(maxVolt.Value), Convert.ToInt32(minVolt.Value)); //create sensors with seed values
                    fObj[counter] = new Filter(counter + 1, 5); //Create filters
                }
                // Get the sensor object values as a string
                //Create AI sensors
                for (int id = 0; id < maxAI; id++)
                {
                    double y = sObj[id].GetValueAI();
                    double yf = fObj[id].MAfilter(y);
                    sTxt = "XX" + y.ToString("0.00") + "XX" + "//" + yf.ToString("0.00") + "//";
                    if (id == 0)
                    {
                        sensorDisplay.Text += now + " ," + sTxt + "V,";
                    }
                    else if (id == maxAI - 1)
                    {
                        sensorDisplay.Text += sTxt + "V,\n";
                    }
                    else
                    {
                        sensorDisplay.Text += sTxt + "V,";
                    }
                }
            }
            else
            {
                // Get the sensor object values as a string
                for (int id = 0; id < maxAI; id++)
                {
                    double y = sObj[id].GetValueAI();
                    double yf = fObj[id].MAfilter(y);
                    sTxt = "XX" + y.ToString("0.00") + "XX" + "//" + yf.ToString("0.00") + "//";
                    if (id == 0)
                    {
                        sensorDisplay.Text += "\r\n" + now + " ," + sTxt + "V,";
                    }
                    else if (id == maxAI - 1)
                    {
                        sensorDisplay.Text += sTxt + "V,";
                    }
                    else
                    {
                        sensorDisplay.Text += sTxt + "V,";
                    }
                }
            }
            //Create DI sensors
            if (first == true)
            {
                for (int id = maxAI; id < maxSid; id++)
                {
                    sTxt = sObj[id].GetValueDI().ToString("0");
                 if (id == maxSid - 1)
                    {
                        sensorDisplay.Text += sTxt + ",\n";
                    }
                    else
                    {
                        sensorDisplay.Text += sTxt + ",";
                    }
                }
            }
            else
            {
                // Get the sensor object values as a string
                for (int id = maxAI; id < maxSid; id++)
                {
                    sTxt = sObj[id].GetValueDI().ToString("0");
                if (id == maxAI - 1)
                    {
                        sensorDisplay.Text += sTxt + ",";
                    }
                    else
                    {
                        sensorDisplay.Text += sTxt + ",";
                    }
                }
            }
            first = false;
            clearSensorText = false;
        }

        public void log()
        {
            logtimeLeft = Convert.ToDouble(logTime.Text);
            loggingTimer.Interval = 100;
            loggingTimer.Start();
            StreamWriter sw = new StreamWriter(pathBox.Text, true);
            sw.WriteLine(sensorDisplay.Text);
            sw.Close();
            clearSensorText = true;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
