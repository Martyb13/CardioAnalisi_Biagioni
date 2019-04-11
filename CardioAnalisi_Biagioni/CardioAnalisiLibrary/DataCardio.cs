using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        static public double Frequenza(double età, ref double min)
        {
            double frequenzamax = 220 - età;
            min = frequenzamax * 70 / 100;
            double max = frequenzamax * 90 / 100;
            return max;
        }
    }
}
