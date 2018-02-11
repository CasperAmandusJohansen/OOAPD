using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQSimulation
{
    class Sensor
    {
        double dVal; int sId; Random rSensVal;
        double smaxVolt, sminVolt;
        int res;

        public Sensor(int id, double maxVolt, double minVolt, int resolution)
        {
            sId = id;
            rSensVal = new Random(id); //id is seed value, will be same always
            smaxVolt = maxVolt;
            sminVolt = minVolt;
            res = resolution;
            //res = (maxVolt - minVolt) / (Math.Pow(2, resolution) - 1);
            dVal = minVolt + (maxVolt - minVolt) * rSensVal.NextDouble();
        }
        public virtual double GetValueAI()
        { //Simulate new reading from DAQ device
            dVal += (rSensVal.NextDouble() - 0.5) * 0.1;             

            //Saturation
            if(dVal > smaxVolt)
            {
                dVal = smaxVolt;
            }
            if(dVal < sminVolt)
            {
                dVal = sminVolt;
            }
            int _dVal = (int)((dVal - sminVolt) * ((1 << res) - 0) / (smaxVolt - sminVolt) + 0);
            dVal = (_dVal - 0) * (smaxVolt - sminVolt) / ((1 << res) - 0) + sminVolt;


            return dVal;
        }
        public virtual double GetValueDI()
        {
            dVal = rSensVal.NextDouble();
            if(dVal <= 0.5)
            {
                dVal = 0;
            }
            else
            {
                dVal = 1;
            }
            return dVal;
        }
        public int GetSensId()
        {
            return sId;
        }
    }
}

