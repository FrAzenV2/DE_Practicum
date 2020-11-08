using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class RungeKuttaMethod : NumericMethod
    {
        private double next_y(double x, double y, double h)
        {
            return y + (k1(x, y, h) + 2 * k2(x, y, h) + 2 * k3(x, y, h) + k4(x, y, h)) / 6;
        }

        private double k1(double x, double y, double h)
        {
            return h * f(x, y);
        }

        private double k2(double x, double y, double h)
        {
            return h * f(x + h / 2, y + k1(x, y, h) / 2);
        }

        private double k3(double x, double y, double h)
        {
            return h * f(x + h / 2, y + k2(x, y, h) / 2);
        }

        private double k4(double x, double y, double h)
        {
            return h * f(x + h, y + k3(x, y, h));
        }

        public Series Solve(double x0, double y0, double X, double h)
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
            series.Name = ("Runge–Kutta method");
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

                error = Math.Abs(solution(next_x(x, h)) - (next_y(x, solution(x), h))); //(solution(x) + h*f(x, y));
                x = next_x(x, h);
            }
            series.Name = ("Runge–Kutta's local error");
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
                if (Math.Abs(x - X) <= 0.0000001)
                {
                    y = next_y(X, y, h);
                    x = X;
                    double tem = Math.Abs(solution(x+h) - y);
                    if (tem > error) error = tem;
                }
                //Debug.WriteLine(ns + " " + error + " - Runge");
                series.Points.AddXY(ns, error);
            }
            series.Name = ("Runge–Kutta's global error");
            return series;
        }
    }
}
