using repulogepTeszteles.Teszt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulogepTeszteles
{
    //Kegyelem 3-mas/2-es a hülye gyereknek? :D


    public class JaratKezelo
    {
        List<Jarat> jaratokList = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            
            var j = new Jarat(jaratSzam,repterHonnan,repterHova,indulas);
            jaratokList.Add(j);
            


        }

        public void Keses(string jaratSzam, int keses)
        {
            

            foreach (var jaratok in jaratokList)
            {
                int kesesek = 0;
                if (jaratok.jaratok.Equals(jaratSzam))
                {
                    kesesek += keses;
                }
                else
                {
                    throw new NegativKesesException(keses);
                }
                kesesek += keses;



            }


        }


   
        public DateTime MikorIndul(string jaratSzam)
        {


            return DateTime.Now;
        }


        public void JaratokRepuloterrol(string repter)
        {




        }

    }


    
}
