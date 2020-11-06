using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public interface NumericMethodsInterface
    {
        Series solve(double x0, double y0, double X, double h);

        Series localError(double x0, double X, double h);

        Series globalError(double x0, double y0, double X, double h);
    }
}
