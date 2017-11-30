namespace rapidCargoEscritorio
{
    partial class frmChart
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
            this.label1 = new System.Windows.Forms.Label();
            this.frmVerChart_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.frmVerChart_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CANTIDAD DE ENCOMIENDAS ENVIADAS POR CADA RUTA";
            // 
            // frmVerChart_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.frmVerChart_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frmVerChart_chart.Legends.Add(legend1);
            this.frmVerChart_chart.Location = new System.Drawing.Point(36, 92);
            this.frmVerChart_chart.Name = "frmVerChart_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Rutas";
            this.frmVerChart_chart.Series.Add(series1);
            this.frmVerChart_chart.Size = new System.Drawing.Size(862, 449);
            this.frmVerChart_chart.TabIndex = 3;
            this.frmVerChart_chart.Text = "chart1";
            // 
            // frmCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 601);
            this.Controls.Add(this.frmVerChart_chart);
            this.Controls.Add(this.label1);
            this.Name = "frmCharts";
            this.Text = "frmCharts";
            ((System.ComponentModel.ISupportInitialize)(this.frmVerChart_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart frmVerChart_chart;
    }
}