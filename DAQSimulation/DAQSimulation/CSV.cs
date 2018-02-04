using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAQSimulation
{
    class CSV
    {
        string _fileName;
        string writer, data;
        double[] value;
        int _maxAi, _maxDi, maxSid;

        public CSV(string fileName, int maxAi, int maxDi)
        {
            _fileName = fileName;
            _maxAi = maxAi;
            _maxDi = maxDi;
            maxSid = maxAi + maxDi;
        }

        public virtual void WriteToCSV(double[] value, DateTime timeStamp)
        {
            string data = "";
            for (int i = 0; i < _maxAi; i++)
            {
                data = data + value[i].ToString("0.00") + ",";
            }
            for (int i = _maxAi; i < maxSid; i++)
            {
                if(i < maxSid-1)
                data = data + value[i].ToString("0") + ",";
                else if(i < maxSid)
                {
                    data = data + value[i].ToString("0");
                }
            }

            writer = timeStamp + "," + data;

            StreamWriter sw = new StreamWriter(_fileName, true);
            sw.WriteLine(writer);
            sw.Close();
        }
    }
}