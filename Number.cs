using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcForTest1
{
    class Number
    {
        public Number(int num)
        {
            this.num = num;
        }
        public int num {get; set;}

        public bool CheckForTwoDigits()
        {
            if (num >= 10 && num <= 99)
                return true;
            else return false;
        }
    }
}
