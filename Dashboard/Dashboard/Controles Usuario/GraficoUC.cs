using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard.Controles_Usuario
{
    public partial class GraficoUC : UserControl
    {
        public GraficoUC()
        {
            InitializeComponent();
        }

        private void chartFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void cargarDatos(int[] mensualidades1, int[] mensualidades2)
        {
            string[] series = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto" , "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            chFactura1.Titles.Add("Facurado cada mes en empresa 1");
            chFactura2.Titles.Add("Facurado cada mes en empresa 2");

            for (int i = 0; i < series.Length; i++)
            {
                // titulos meses
                Series serie1 = chFactura1.Series.Add(series[i]);
                Series serie2 = chFactura2.Series.Add(series[i]);

                //valor al mes
                serie1.Points.Add(mensualidades1[i]);
                serie2.Points.Add(mensualidades2[i]);
            }
        }
    }
}
