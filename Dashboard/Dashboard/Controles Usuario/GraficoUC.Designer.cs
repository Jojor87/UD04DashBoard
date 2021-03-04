
namespace Dashboard.Controles_Usuario
{
    partial class GraficoUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chFactura1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chFactura2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chFactura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFactura2)).BeginInit();
            this.SuspendLayout();
            // 
            // chFactura1
            // 
            chartArea1.Name = "ChartArea1";
            this.chFactura1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFactura1.Legends.Add(legend1);
            this.chFactura1.Location = new System.Drawing.Point(3, 3);
            this.chFactura1.Name = "chFactura1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chFactura1.Series.Add(series1);
            this.chFactura1.Size = new System.Drawing.Size(449, 594);
            this.chFactura1.TabIndex = 0;
            this.chFactura1.Text = "chart1";
            this.chFactura1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chFactura2
            // 
            chartArea2.Name = "ChartArea1";
            this.chFactura2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chFactura2.Legends.Add(legend2);
            this.chFactura2.Location = new System.Drawing.Point(451, 3);
            this.chFactura2.Name = "chFactura2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chFactura2.Series.Add(series2);
            this.chFactura2.Size = new System.Drawing.Size(449, 594);
            this.chFactura2.TabIndex = 1;
            // 
            // GraficoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chFactura2);
            this.Controls.Add(this.chFactura1);
            this.Name = "GraficoUC";
            this.Size = new System.Drawing.Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)(this.chFactura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFactura2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chFactura1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFactura2;
    }
}
