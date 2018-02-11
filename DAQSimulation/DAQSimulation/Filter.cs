using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQSimulation
{
    class Filter
    {
        int sId;
        int _arLength; //Filter constant should be atleast 5*T_s
        private bool d = false;
        double[] avgArray = new double[5]; //TO initialize
        public Filter(int id, int arlength)
        {
            _arLength = arlength;
            Array.Resize(ref avgArray, _arLength); //MAke the array resizble from the main program.
            sId = id;
            
        }
        public virtual double MAfilter(double y)
        {
            double yf;
            if (d == false)
            {
                for (int i = 0; i <= _arLength-1; i++) //Fill array with first input
                {
                    avgArray[i] = y;
                }
                d = true;
            }
            else {
                //avgArray[4] = avgArray[3];
                //avgArray[3] = avgArray[2];
                //avgArray[2] = avgArray[1];
                //avgArray[1] = avgArray[0];
                for (int i = _arLength - 1; i >= 1; i--)
                {
                        
                    avgArray[i] = avgArray[i-1]; //Shift array
                }
                avgArray[0] = y;
            }
            yf = avgArray.Sum() / _arLength;
            return yf;
        }
    }
}
