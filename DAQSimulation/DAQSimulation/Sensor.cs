using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQSimulation
{

    class Sensor
    /// <summary> ////////////////////////////////////////////////////////////////////
    /// public class Sensor
    /// Purpose: Create random sensor values from seeds with a minimum and maximum voltage and a given resolution.
    /// /// Version: 1.0: First version: 11-FEB-18: CAJ
    /// </summary>
    {
        double dVal; int sId; Random rSensVal;
        double smaxVolt, sminVolt;
        int res;
        /// <summary> ////////////////////////////////////////////////////////////////////
        public Sensor(int id, double maxVolt, double minVolt, int resolution)
        /// Purpose: Constructor 
        /// /// Version: 1.0: First version: 11-FEB-18: CAJ
        /// </summary>
        {
            sId = id;
            rSensVal = new Random(id); //id is seed value, will be same always
            smaxVolt = maxVolt;
            sminVolt = minVolt;
            res = resolution;
            dVal = minVolt + (maxVolt - minVolt) * rSensVal.NextDouble();
        }
        /// <summary> ////////////////////////////////////////////////////////////////////
        public virtual double GetValueAI()
        /// Purpose: Get random analog sensor value 
        /// /// Version: 1.0: First version: 11-FEB-18: CAJ
        /// </summary>
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
        public virtual int GetValueDI()
        /// <summary> ////////////////////////////////////////////////////////////////////
        /// Purpose: Get random digital sensor value 
        /// /// Version: 1.0: First version: 11-FEB-18: CAJ
        /// </summary>
        {
            dVal = rSensVal.NextDouble();
            int bVal;
            if(dVal <= 0.5)
            {
                bVal = 0;
            }
            else
            {
                bVal = 1;
            }
            return bVal;
        }
        public int GetSensId()
        /// <summary> ////////////////////////////////////////////////////////////////////
        /// Purpose: Get Sensor ID
        /// /// Version: 1.0: First version: 11-FEB-18: CAJ
        /// </summary>
        {
            return sId;
        }
    }
}

