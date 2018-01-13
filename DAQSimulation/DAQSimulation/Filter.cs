using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQSimulation
{
    class Filter
    {

        public double yk;
        public double T_s;
        public double T_f;
        public double movingAvgFilter(double y, int sId)
        {
            double a;
            double yf;
            a = T_s / (T_s + T_f);
            yf = (1 - a) * yk + a * y;
            yk = yf;
            return yf;
        }
    }
}
