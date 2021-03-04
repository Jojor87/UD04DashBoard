using Dashboard.Controles_Usuario;
using DashboardBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesDashboard;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tlp;
        private DatosComercialUC dUC;
        private GraficoUC guc;
        private ComercialVO comercial;
        private Facturacion facturacion1;
        private Facturacion facturacion2;
        private int numComercial; // variable para saber que comercial se selecciona

        public Form1()
        {
            InitializeComponent();
            tlp = tlpBase;
            dUC = new Controles_Usuario.DatosComercialUC();
            guc = new Controles_Usuario.GraficoUC();
        }

        //botones comercial
        private void btnComercial1_Click(object sender, EventArgs e)
        {
            //tlp.Controls.Add(gb, 0, 0); // Lo añade en la columna 1, fila 1

            this.comercial = new ComercialVO(1);
            
            numComercial = 1;

            pnSeleccion.Location = btnComercial1.Location;
            pnSeleccion.Visible = true;
            pnIzq.Visible = false;
        }

        private void btnComercial2_Click(object sender, EventArgs e)
        {
            //tlp.Controls.Add(gb, 0, 0); // Lo añade en la columna 1, fila 1

            this.comercial = new ComercialVO(2);
            numComercial = 2;

            pnSeleccion.Location = btnComercial2.Location;
            pnSeleccion.Visible = true;
            pnIzq.Visible = false;
        }

        private void btnComercial3_Click(object sender, EventArgs e)
        {
            //tlp.Controls.Add(gb, 0, 0); // Lo añade en la columna 1, fila 1

            this.comercial = new ComercialVO(3);
            numComercial = 3;

            pnSeleccion.Location = btnComercial3.Location;
            pnSeleccion.Visible = true;
            pnIzq.Visible = false;
        }

        //botones datos
        private void btnDatosC_Click(object sender, EventArgs e)
        {
            pnIzq.Top = btnDatosC.Top;
            pnIzq.Visible = true;

            ComercialBLL comercialDatos = new ComercialBLL();

            dUC.pintaTextBox(comercialDatos.gestionaDatos(comercial));

            tlp.Controls.Remove(guc); // Elimina el control datos comercial
            tlp.Controls.Add(dUC, 0, 0); // Lo añade en la columna 0, fila 0
        }

        private void btnFacturación_Click(object sender, EventArgs e)
        {
            pnIzq.Top = btnFacturación.Top;
            pnIzq.Visible = true;

            facturacion1 = new Facturacion(numComercial, 1);
            facturacion2 = new Facturacion(numComercial, 2);
            ComercialBLL comercialDatos = new ComercialBLL();
            dUC.pintaTextBoxFacturacion(comercialDatos.gestionaFactura(facturacion1), comercialDatos.gestionaFactura(facturacion2));
            tlp.Controls.Remove(guc); // Elimina el control datos comercial
            tlp.Controls.Add(dUC, 0, 0); // Lo añade en la columna 0, fila 0

        }

        private void btnResumenV_Click(object sender, EventArgs e)
        {
            pnIzq.Top = btnResumenV.Top;  // posiciona el marcador a la altura del botón pulsado
            pnIzq.Visible = true;

            tlp.Controls.Remove(dUC); // Elimina el control datos comercial
            guc.cargarDatos(facturacion1.mes, facturacion2.mes);
            tlp.Controls.Add(guc, 0, 0); // Lo añade en la columna 0, fila 0
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpBase_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
