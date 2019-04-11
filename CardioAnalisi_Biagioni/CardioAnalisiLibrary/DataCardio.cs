using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        static public int Frequenza(int età, ref int min)
        {
            int frequenzamax = 220 - età;
            min = frequenzamax * 70 / 100;
            int max = frequenzamax * 90 / 100;
            return max;
        }
    }
}
