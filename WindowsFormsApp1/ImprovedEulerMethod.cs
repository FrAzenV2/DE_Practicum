using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class ImprovedEulerMethod : NumericMethod
    {
        private double next_y(double x, double y, double h)
        {
            return y + h * ((f(x, y) + f(next_x(x, h), y + h * f(x, y))) / 2);
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
            series.ChartType = SeriesChartType.Line;
            series.Name="Improved Euler's method";
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
            series.Name="Improved Euler's local error";
            return series;
        }

        public Series GlobalError(double x0, double y0, double X, double h)
        {
            double x = x0;
            double y = y0;
            double error = Math.Abs(solution(x) - y);


            Series series = new Series();
            while (x <= X)
            {
                series.Points.AddXY(x, error);

                y = next_y(x, y, h);
                x = next_x(x, h);
                error = Math.Abs(solution(x) - y);
            }
            series.Name = "Improved Euler's global error";
            return series;
        }
    }
}
