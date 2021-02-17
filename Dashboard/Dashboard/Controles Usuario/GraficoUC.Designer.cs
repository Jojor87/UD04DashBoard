
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
            this.chartFacturacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFacturacion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFacturacion.ChartAreas.Add(chartArea1);
            this.chartFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFacturacion.Legends.Add(legend1);
            this.chartFacturacion.Location = new System.Drawing.Point(0, 0);
            this.chartFacturacion.Name = "chartFacturacion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFacturacion.Series.Add(series1);
            this.chartFacturacion.Size = new System.Drawing.Size(737, 489);
            this.chartFacturacion.TabIndex = 0;
            this.chartFacturacion.Text = "chart1";
            this.chartFacturacion.Click += new System.EventHandler(this.chartFacturacion_Click);
            // 
            // GraficoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartFacturacion);
            this.Name = "GraficoUC";
            this.Size = new System.Drawing.Size(737, 489);
            ((System.ComponentModel.ISupportInitialize)(this.chartFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFacturacion;
    }
}
