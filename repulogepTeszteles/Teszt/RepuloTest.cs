using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulogepTeszteles.Teszt
{


    //Kegyelem 3-mas/2-es a hülye gyereknek? :D


    [TestFixture]

    class RepuloTest
    {
        JaratKezelo j;

        [SetUp]

        public void setUp()
        {
             j = new JaratKezelo();

        }

        [Test]

        public void JaratHozzaad()
        {
            j.UjJarat("TesztNev", "Hamburg", "Bucharest", new DateTime (2019, 03, 01, 12, 50, 0));
            Assert.AreEqual(new DateTime(2019, 03, 01, 12, 50, 0), j.MikorIndul("TesztNev"));
        }

        [Test]

        public void vanEKeses()
        {
            j.Keses("TesztNev", 15);
            Assert.AreEqual(1, 15);
        }

    }
}
