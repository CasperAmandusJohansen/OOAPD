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

        public Sensor(int id, int maxVolt, int minVolt)
        {
            sId = id;
            rSensVal = new Random(id); //id is seed value, will be same always
            dVal = minVolt + (maxVolt - minVolt) * rSensVal.NextDouble();
        }
        public virtual double GetValueAI()
        { //Simulate new reading from DAQ device
            dVal += ((rSensVal.NextDouble() - 0.5F) /  10.0F); //Changing 10.0F changes resolution
            return dVal;
        }
        public virtual double GetValueDI()
        {
            dVal += ((rSensVal.NextDouble() - 0.5F) / 1.0F);
            if(dVal <= 0)
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
    /*
    //Temperature sensor
    class SensTemp : Sensor
    {
        public SensTemp(int ch, int maxVolt, int minVolt) : base(ch, maxVolt, minVolt)
        {
        }
        public override double GetValue()
        {
            double dVal = base.GetValue();
            //Convert DAQ voltage to temp range -25 to 125
            dVal *= 30F; //Range 150/5
            dVal -= 25.0F; //Offset adjust
            return dVal;
        }
    }
    //Temperature sensor

        
    class SensFlow : Sensor
    {
        public SensFlow(int ch, int maxVolt, int minVolt) : base(ch, maxVolt, minVolt)
        {
        }
        public override double GetValue()
        {
            double dVal = base.GetValue();
            //Convert DAQ voltage to temp range -25 to 125
            dVal *= 40F; //Range 0-40 l/s
            return dVal;
        }
    }*/
}

