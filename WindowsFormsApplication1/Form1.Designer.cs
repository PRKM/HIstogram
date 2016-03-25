namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Original = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.Location = new System.Drawing.Point(6, 3);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(332, 319);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Original.TabIndex = 0;
            this.Original.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // histogram
            // 
            this.histogram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.histogram.ChartAreas.Add(chartArea1);
            this.histogram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.histogram.Legends.Add(legend1);
            this.histogram.Location = new System.Drawing.Point(344, 3);
            this.histogram.Name = "histogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histogram.Series.Add(series1);
            this.histogram.Size = new System.Drawing.Size(328, 319);
            this.histogram.TabIndex = 3;
            this.histogram.Text = "histogram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Original);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogram;
    }
}

