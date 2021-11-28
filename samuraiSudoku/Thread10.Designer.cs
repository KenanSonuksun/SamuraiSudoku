
namespace samuraiSudoku
{
    partial class Thread10
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
            this.solveButtonForThread5 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sudokuHarita = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // solveButtonForThread5
            // 
            this.solveButtonForThread5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.solveButtonForThread5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButtonForThread5.ForeColor = System.Drawing.SystemColors.Control;
            this.solveButtonForThread5.Location = new System.Drawing.Point(645, 12);
            this.solveButtonForThread5.Name = "solveButtonForThread5";
            this.solveButtonForThread5.Size = new System.Drawing.Size(170, 56);
            this.solveButtonForThread5.TabIndex = 13;
            this.solveButtonForThread5.Text = "Solve";
            this.solveButtonForThread5.UseVisualStyleBackColor = false;
            this.solveButtonForThread5.Click += new System.EventHandler(this.solveButtonForThread5_Click);
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(645, 89);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "zamanKare";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(481, 467);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // sudokuHarita
            // 
            this.sudokuHarita.Location = new System.Drawing.Point(2, 3);
            this.sudokuHarita.Name = "sudokuHarita";
            this.sudokuHarita.Size = new System.Drawing.Size(595, 596);
            this.sudokuHarita.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1019, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Time = 0";
            // 
            // Thread10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.solveButtonForThread5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.sudokuHarita);
            this.Name = "Thread10";
            this.Text = "Thread10";
            this.Load += new System.EventHandler(this.Thread10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveButtonForThread5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel sudokuHarita;
        private System.Windows.Forms.Label label2;
    }
}