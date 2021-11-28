
namespace samuraiSudoku
{
    partial class HomePage
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
            this.thread5Button = new System.Windows.Forms.Button();
            this.thread10Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thread5Button
            // 
            this.thread5Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thread5Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.thread5Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thread5Button.Location = new System.Drawing.Point(200, 177);
            this.thread5Button.Name = "thread5Button";
            this.thread5Button.Size = new System.Drawing.Size(131, 51);
            this.thread5Button.TabIndex = 0;
            this.thread5Button.Text = "5 Thread İle Çöz";
            this.thread5Button.UseVisualStyleBackColor = false;
            this.thread5Button.Click += new System.EventHandler(this.thread5Button_Click);
            // 
            // thread10Button
            // 
            this.thread10Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thread10Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.thread10Button.ForeColor = System.Drawing.SystemColors.Control;
            this.thread10Button.Location = new System.Drawing.Point(452, 177);
            this.thread10Button.Name = "thread10Button";
            this.thread10Button.Size = new System.Drawing.Size(128, 51);
            this.thread10Button.TabIndex = 1;
            this.thread10Button.Text = "10 Thread İle Çöz";
            this.thread10Button.UseVisualStyleBackColor = false;
            this.thread10Button.Click += new System.EventHandler(this.thread10Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(726, 98);
            this.label3.TabIndex = 12;
            this.label3.Text = "SAMURAI SUDOKU";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(842, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thread10Button);
            this.Controls.Add(this.thread5Button);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thread5Button;
        private System.Windows.Forms.Button thread10Button;
        private System.Windows.Forms.Label label3;
    }
}