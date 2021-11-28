
namespace samuraiSudoku
{
    partial class Thread5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.solveButtonForThread5 = new System.Windows.Forms.Button();
            this.sudokuHarita = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(641, 87);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "zamanKare";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(481, 467);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // solveButtonForThread5
            // 
            this.solveButtonForThread5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.solveButtonForThread5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButtonForThread5.ForeColor = System.Drawing.SystemColors.Control;
            this.solveButtonForThread5.Location = new System.Drawing.Point(641, 12);
            this.solveButtonForThread5.Name = "solveButtonForThread5";
            this.solveButtonForThread5.Size = new System.Drawing.Size(170, 56);
            this.solveButtonForThread5.TabIndex = 9;
            this.solveButtonForThread5.Text = "Solve";
            this.solveButtonForThread5.UseVisualStyleBackColor = false;
            this.solveButtonForThread5.Click += new System.EventHandler(this.solveButtonForThread5_Click);
            // 
            // sudokuHarita
            // 
            this.sudokuHarita.Location = new System.Drawing.Point(2, 2);
            this.sudokuHarita.Name = "sudokuHarita";
            this.sudokuHarita.Size = new System.Drawing.Size(595, 599);
            this.sudokuHarita.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Time = 0";
            // 
            // Thread5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sudokuHarita);
            this.Controls.Add(this.solveButtonForThread5);
            this.Controls.Add(this.chart1);
            this.Name = "Thread5";
            this.Text = "Thread 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button solveButtonForThread5;
        private System.Windows.Forms.Panel sudokuHarita;
        private System.Windows.Forms.Label label1;
    }
}

