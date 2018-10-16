using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class play
    {
        public int Sn;
        public int random_number()
        {
            //below code for spining the chamber and it will pick bullet randomly
            Random rnd = new Random();
            //below code helps to pick random number between 1-7.
            return Sn = rnd.Next(1, 7);
        }

        public int spin_chamber(int a)
        {
            if (a == 6)
            {
                a = 1;
            }
            else
            {
                a++;
            }
            return a;
        }
    }
}
