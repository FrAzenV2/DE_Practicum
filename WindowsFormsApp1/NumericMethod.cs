using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class NumericMethod : NumericMethodsInterface
    {
        public bool invalidDouble(Double y)
        {
            return Double.IsInfinity(y) || Double.IsNaN(y);
        }
        
        public double f(double x, double y)
        {
            return ((3 * y + 2 * x * y) / Math.Pow(x, 2));// (2 * Math.Pow(x, 3) + 2 * y / x); - 4 var/ curr -22
        }

        public double solution(double x)
        {
            return Math.Exp(3) * Math.Exp(-3.0f / x) * Math.Pow(x, 2); //(Math.Pow(x, 2) + Math.Pow(x, 4));  - 22 var
        }

        public double next_x(double x, double h)
        {
            return x + h;
        }

        public Series globalError(double x0, double y0, double X, double h)
        {
            throw new NotImplementedException();
        }

        public Series localError(double x0, double X, double h)
        {
            throw new NotImplementedException();
        }

        public Series solve(double x0, double y0, double X, double h)
        {
            throw new NotImplementedException();
        }
    }
}
