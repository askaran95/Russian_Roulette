using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [TestFixture]
    class Testing
    {
        [TestCase]
        public void spin_positive()
        {
            play positive = new play();
            Assert.AreEqual(1, positive.spin_chamber(6));
        }


        [TestCase]
        public void spin_negative()
        {
            play negative = new play();
            Assert.AreNotEqual(2, negative.spin_chamber(6));
        }
    }
}
