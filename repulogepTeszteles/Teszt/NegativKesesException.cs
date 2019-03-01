using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulogepTeszteles.Teszt
{

    //Kegyelem 3-mas/2-es a hülye gyereknek? :D

    class NegativKesesException : Exception
    {

        public NegativKesesException(int keses)
            : base("Negatívan nehéz késni:" + keses.ToString())

        {

        }

    }
}