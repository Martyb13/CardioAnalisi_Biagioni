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
        static public string Condizioni(int battiti)
        {
            string msg = "";
            if(battiti<=0)
            {
                msg = "Errore!!";
            }
            else if (battiti < 60)
            {
                msg = "Bradicardia";
            }
            else if (battiti > 60 && battiti < 100)
            {
                msg = "Normale";
            }
            else
            {
                msg = "Tachicardia";
            }
            return msg;
        }
    }
}
