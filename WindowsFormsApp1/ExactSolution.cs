using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public class ExactSolution : NumericMethod
    {
        public Series Solve(double x0, double y0, double X, double h)
        {

            double x = x0;
            double y = solution(x);

            Series series = new Series();
            while (x <= X)
            {
                series.Points.AddXY(x, y);

                x = next_x(x, h);
                y = solution(x);

                if (invalidDouble(y))
                {
                    return null;
                }
            }
            series.Name = "Exact solution";
            series.BorderColor = Color.Orange;
            return series;
        }
    }
}
