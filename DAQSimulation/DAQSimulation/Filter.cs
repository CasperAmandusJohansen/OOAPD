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
        public int arLength; //Filter constant should be atleast 5*T_s
        private bool d;
        double[] avgArray = new double[5]; //TO initialize
        public Filter(int id, int arlength)
        {
            arLength = arlength;
            Array.Resize(ref avgArray, arLength); //MAke the array resizble from the main program.
            sId = id;
            
        }
        public virtual double MAfilter(double y)
        {
            if (d == false)
            {
                for (int i = 0; i <= arLength-1; i++) //Fill array with first input
                {
                    avgArray[i] = y;
                }
                d = true;
                return y;
            }
            else { 
            double yf;
            for (int i = 1; i <= arLength-1; i++)
                {
                    avgArray[i] = avgArray[i-1]; //Shift array
            }
            avgArray[0] = y; //Set first index equal to input
            yf = avgArray.Sum() / arLength;
            return yf;
            }
        }
    }
}
