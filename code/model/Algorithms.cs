using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Algorithms
    {
        private Double a;
        private Double b;

        public Algorithms()
        {
         
        }

        public void Coefficients(List<Double> x, List<Double> y, String Departament)
        {
            //Double LinearRegresion = 0;
            Double SumX = Summation(0, x.Count - 1, x);
            Double SumY = Summation(0, y.Count - 1, y);
            List<Double> SqX = Squared(x);
            List<Double> SqY = Squared(y);
            List<Double> MultXY = Multuply(x, y);
            Double SumSqX = Summation(0, x.Count - 1, SqX);
            Double SumSqY = Summation(0, y.Count - 1, SqY);
            Double SumMXY = Summation(0, MultXY.Count - 1, MultXY);
            a = ((MultXY.Count * SumMXY) - (SumX * SumY))/((SqX.Count*SumSqX) - Math.Pow(SumSqX, 2));
            b = ((SumY) - (a * SumX)) /(x.Count);
            //return LinearRegresion;
        }

        public Double LinearRegresion(Double x) 
        {
            Double y = (a * x) + b;
            return y;
        }

        private Double Summation(int First, int Last, List<Double> Variables) {
            if (First == Last)
            {
                return Variables[First];
            }
            else
            {
                int Middle = (First + Last) / 2;
                Double s = Summation(First, Middle, Variables);
                Double t = Summation(Middle + 1, Last, Variables);
                return s + t;
            }
        }

        private List<Double> Squared(List<Double> Variables) {
            List<Double> sn = new List<double>();
            for (int i = 0; i < Variables.Count - 1; i++)
            {
                sn[i] = Variables[i] * Variables[i];
            }
            return sn;
        }

        private List<Double> Multuply(List<Double> x, List<Double> y)
        {
            List<Double> multiply = new List<double>();
            for (int i = 0; i < x.Count-1; i++)
            {
                multiply[i] = x[i] * y[i];
            }
            return multiply;
        }

    }
}
