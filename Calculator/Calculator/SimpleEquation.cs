using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleEquation
    {
        double a, b;
        public SimpleEquation(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public string SingleEquation()
        {
            string result;
            if (a == 0)
                if (b == 0)
                    result = "VSN";
                else
                    result = "VN";
            else
                result = -b / a + "";
            return result;
        }

    }
}

