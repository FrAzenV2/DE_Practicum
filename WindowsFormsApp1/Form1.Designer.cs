namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GTEGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LTEGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ErrorText = new System.Windows.Forms.Label();
            this.plot_button = new System.Windows.Forms.Button();
            this.Runge_check = new System.Windows.Forms.CheckBox();
            this.EulerImp_check = new System.Windows.Forms.CheckBox();
            this.Euler_check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.n_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.x_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.y0_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x0_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GTEGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTEGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GTEGraph);
            this.splitContainer1.Panel1.Controls.Add(this.LTEGraph);
            this.splitContainer1.Panel1.Controls.Add(this.MainGraph);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ErrorText);
            this.splitContainer1.Panel2.Controls.Add(this.plot_button);
            this.splitContainer1.Panel2.Controls.Add(this.Runge_check);
            this.splitContainer1.Panel2.Controls.Add(this.EulerImp_check);
            this.splitContainer1.Panel2.Controls.Add(this.Euler_check);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.n_input);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.x_input);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.y0_input);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.x0_input);
            this.splitContainer1.Size = new System.Drawing.Size(1006, 673);
            this.splitContainer1.SplitterDistance = 728;
            this.splitContainer1.TabIndex = 0;
            // 
            // GTEGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.GTEGraph.ChartAreas.Add(chartArea1);
            this.GTEGraph.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.GTEGraph.Legends.Add(legend1);
            this.GTEGraph.Location = new System.Drawing.Point(371, 432);
            this.GTEGraph.Name = "GTEGraph";
            this.GTEGraph.Size = new System.Drawing.Size(357, 241);
            this.GTEGraph.TabIndex = 2;
            this.GTEGraph.Text = "LocalErrors";
            // 
            // LTEGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.LTEGraph.ChartAreas.Add(chartArea2);
            this.LTEGraph.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.LTEGraph.Legends.Add(legend2);
            this.LTEGraph.Location = new System.Drawing.Point(0, 432);
            this.LTEGraph.Name = "LTEGraph";
            this.LTEGraph.Size = new System.Drawing.Size(371, 241);
            this.LTEGraph.TabIndex = 1;
            this.LTEGraph.Text = "LocalErrors";
            // 
            // MainGraph
            // 
            chartArea3.Name = "ChartArea1";
            this.MainGraph.ChartAreas.Add(chartArea3);
            this.MainGraph.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.MainGraph.Legends.Add(legend3);
            this.MainGraph.Location = new System.Drawing.Point(0, 0);
            this.MainGraph.Name = "MainGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MainGraph.Series.Add(series1);
            this.MainGraph.Size = new System.Drawing.Size(728, 432);
            this.MainGraph.TabIndex = 0;
            this.MainGraph.Text = "Graph";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(76, 558);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(132, 16);
            this.ErrorText.TabIndex = 12;
            this.ErrorText.Text = "Some Error oquried";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorText.Visible = false;
            // 
            // plot_button
            // 
            this.plot_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plot_button.Location = new System.Drawing.Point(0, 577);
            this.plot_button.Name = "plot_button";
            this.plot_button.Size = new System.Drawing.Size(274, 96);
            this.plot_button.TabIndex = 11;
            this.plot_button.Text = "Plot";
            this.plot_button.UseVisualStyleBackColor = true;
            this.plot_button.Click += new System.EventHandler(this.plotTheGraphs);
            // 
            // Runge_check
            // 
            this.Runge_check.AutoSize = true;
            this.Runge_check.Location = new System.Drawing.Point(22, 218);
            this.Runge_check.Name = "Runge_check";
            this.Runge_check.Size = new System.Drawing.Size(161, 20);
            this.Runge_check.TabIndex = 10;
            this.Runge_check.Text = "Runge-Kutta Method";
            this.Runge_check.UseVisualStyleBackColor = true;
            this.Runge_check.CheckedChanged += new System.EventHandler(this.Runge_check_changed);
            // 
            // EulerImp_check
            // 
            this.EulerImp_check.AutoSize = true;
            this.EulerImp_check.Location = new System.Drawing.Point(22, 182);
            this.EulerImp_check.Name = "EulerImp_check";
            this.EulerImp_check.Size = new System.Drawing.Size(186, 20);
            this.EulerImp_check.TabIndex = 9;
            this.EulerImp_check.Text = "Improved Euler’s method";
            this.EulerImp_check.UseVisualStyleBackColor = true;
            this.EulerImp_check.CheckedChanged += new System.EventHandler(this.EulerImp_check_CheckedChanged);
            // 
            // Euler_check
            // 
            this.Euler_check.AutoSize = true;
            this.Euler_check.Location = new System.Drawing.Point(22, 147);
            this.Euler_check.Name = "Euler_check";
            this.Euler_check.Size = new System.Drawing.Size(124, 20);
            this.Euler_check.TabIndex = 8;
            this.Euler_check.Text = "Euler\'s Method";
            this.Euler_check.UseVisualStyleBackColor = true;
            this.Euler_check.CheckedChanged += new System.EventHandler(this.Euler_changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "N";
            // 
            // n_input
            // 
            this.n_input.Location = new System.Drawing.Point(47, 96);
            this.n_input.Multiline = true;
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(212, 22);
            this.n_input.TabIndex = 6;
            this.n_input.Text = "10";
            this.n_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // x_input
            // 
            this.x_input.Location = new System.Drawing.Point(47, 68);
            this.x_input.Multiline = true;
            this.x_input.Name = "x_input";
            this.x_input.Size = new System.Drawing.Size(212, 22);
            this.x_input.TabIndex = 4;
            this.x_input.Text = "6";
            this.x_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "y0";
            // 
            // y0_input
            // 
            this.y0_input.Location = new System.Drawing.Point(47, 40);
            this.y0_input.Multiline = true;
            this.y0_input.Name = "y0_input";
            this.y0_input.Size = new System.Drawing.Size(212, 22);
            this.y0_input.TabIndex = 2;
            this.y0_input.Text = "1";
            this.y0_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y0_input.TextChanged += new System.EventHandler(this.y0_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "x0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // x0_input
            // 
            this.x0_input.Location = new System.Drawing.Point(47, 12);
            this.x0_input.Multiline = true;
            this.x0_input.Name = "x0_input";
            this.x0_input.Size = new System.Drawing.Size(212, 22);
            this.x0_input.TabIndex = 0;
            this.x0_input.Text = "1";
            this.x0_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x0_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DE Practicum ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GTEGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTEGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart LTEGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainGraph;
        private System.Windows.Forms.TextBox x0_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y0_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox n_input;
        private System.Windows.Forms.CheckBox Runge_check;
        private System.Windows.Forms.CheckBox EulerImp_check;
        private System.Windows.Forms.CheckBox Euler_check;
        private System.Windows.Forms.DataVisualization.Charting.Chart GTEGraph;
        private System.Windows.Forms.Button plot_button;
        private System.Windows.Forms.Label ErrorText;
    }
}

