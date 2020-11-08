using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class EulerMethod : NumericMethod
    {
        private double next_y(double x, double y, double h)
        {
            return y + h * f(x, y);
        }

        public new Series solve(double x0, double y0, double X, double h)
        {
            double x = x0;
            double y = y0;

            Series series = new Series();
            while (x <= X)
            {
                series.Points.AddXY(x, y);

                y = next_y(x, y, h);
                x = next_x(x, h);
                if (invalidDouble(y))
                {
                    return null;
                }
            }
            series.Name = "Euler's method";
            return series;
        }

        public Series LocalError(double x0, double X, double h)
        {
            double x = x0;
            double error = 0;

            Series series = new Series();
            while (x <= X)
            {
                series.Points.AddXY(x, error);
                error = Math.Abs(solution(next_x(x, h)) - (next_y(x, solution(x), h)));
                x = next_x(x, h);
            }
            series.Name = "Euler's local error";
            return series;
        }

        public Series GlobalError(double x0, double y0, double X, double n0, double N)
        {
            Series series = new Series();
            for (double ns = n0; ns <= N; ns++)
            {
                double h = (X - x0) / ns;
                double x = x0;
                double y = y0;
                double error = Math.Abs(solution(x) - y);



                for (; x <= X; x += h)
                {

                    y = next_y(x, y, h);
                    //x = next_x(x, h);
                    double temp = Math.Abs(solution(x+h) - y);
                    if (temp > error) error = temp;
                }
                if (Math.Abs(x - X) <= 0.000001)
                {
                    y = next_y(X, y, h);
                    x = X;
                    double tem = Math.Abs(solution(x+h) - y);
                    if (tem > error) error = tem;
                }
                series.Points.AddXY(ns, error);
            }
            series.Name = ("Euler's global error");
            return series;
        }
    }
}
