using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    static class Algorithms
    {
        public static Double LinearRegresion(List<Double> x, List<Double> y, String Departament) {
            Double LinearRegresion = 0;


            return LinearRegresion;
        }

        private static Double Summation(int First, int Last, List<Double> Variables) {
            if (First == Last)
            {
                return Variables[First];
            }
            else {
                int Middle = (First + Last) / 2;
                Double s = Summation(First, Middle, Variables);
                Double t = Summation(Middle+1, Last, Variables);
                return s + t;
            }
        }
    }
}
