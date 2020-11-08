using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EulerImp_check_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Euler_changed(object sender, EventArgs e)
        {

        }

        private void Runge_check_changed(object sender, EventArgs e)
        {

        }

        private void plotTheGraphs(object sender, EventArgs e)
        {
            double x0, y0, X, N, h, n0;
            try
            {
                x0 = Double.Parse(x0_input.Text);
                y0 = Double.Parse(y0_input.Text);
                X = Double.Parse(x_input.Text);
                N = Double.Parse(n_input.Text);
                n0 = Double.Parse(n0_textbox.Text);
                h = (X - x0) / N;
            } catch
            {
                ErrorText.Text = "Some Error in input Values!";
                ErrorText.Visible = true;
                return;
            }
            if(x0 <=0 || y0<=0)
            {
                ErrorText.Text = "Function f(x,y) is undefined on intialial values!";
                ErrorText.Visible = true;
                return;
            }

            ErrorText.Visible = false;
            MainGraph.Series.Clear();
            LTEGraph.Series.Clear();
            GTEGraph.Series.Clear();

            if (Euler_check.Checked)
            {
                plotEuler(x0, y0, X, h, N, n0);
            }

            if (EulerImp_check.Checked)
            {
                plotEulerImp(x0, y0, X, h, N, n0);
            }

            if (Runge_check.Checked)
            {
                plotRungeKutta(x0, y0, X, h, N, n0);
            }

            if (Exact_check.Checked)
            {
                plotExactSol(x0, y0, X, h);
            }
        }

        void plotEuler(double x0, double y0, double X, double h, double N, double n0)
        {
            EulerMethod eulerMethod = new EulerMethod();
            Series series = eulerMethod.solve(x0, y0, X, h);
            Debug.WriteLine(series.Points);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            MainGraph.Series.Add(series);
            series = eulerMethod.LocalError(x0, X, h);
            series.BorderWidth = 2;
            series.ChartType = SeriesChartType.Line;
            LTEGraph.Series.Add(series);
            series = eulerMethod.GlobalError(x0, y0, X, n0,N);
            series.BorderWidth = 2;
            series.ChartType = SeriesChartType.Line;
            GTEGraph.Series.Add(series);
        }

        void plotEulerImp(double x0, double y0, double X, double h, double N, double n0)
        {
            ImprovedEulerMethod improved = new ImprovedEulerMethod();
            Series series = improved.Solve(x0, y0, X, h);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            MainGraph.Series.Add(series);
            series = improved.LocalError(x0, X, h);
            series.BorderWidth = 2;
            series.ChartType = SeriesChartType.Line;
            LTEGraph.Series.Add(series);
            series = improved.GlobalError(x0, y0, X, n0, N);
            series.BorderWidth = 2;
            series.ChartType = SeriesChartType.Line;
            GTEGraph.Series.Add(series);
        }

        void plotRungeKutta(double x0, double y0, double X, double h, double N, double n0)
        {
            RungeKuttaMethod rungeKutta = new RungeKuttaMethod();
            Series series = rungeKutta.Solve(x0, y0, X, h);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            MainGraph.Series.Add(series);
            series = rungeKutta.LocalError(x0, X, h);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            LTEGraph.Series.Add(series);
            series = rungeKutta.GlobalError(x0, y0, X, n0, N);
            series.BorderWidth = 2;
            series.ChartType = SeriesChartType.Line;
            GTEGraph.Series.Add(series);
        }

        void plotExactSol(double x0, double y0, double X, double h)
        {
            ExactSolution solution = new ExactSolution();
            Series series = solution.Solve(x0, y0, X, h);
            series.BorderWidth = 2;
            series.ChartType = SeriesChartType.Line;
            MainGraph.Series.Add(series);
        }

    } 
}
