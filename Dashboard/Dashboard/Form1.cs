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
        private DatosComercialUC gb;
        public Form1()
        {
            InitializeComponent();
            tlp = tlpBase;
            gb = new Controles_Usuario.DatosComercialUC();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComercial1_Click(object sender, EventArgs e)
        {
            tlp.Controls.Add(gb, 0, 0); // Lo añade en la columna 1, fila 1

            ComercialVO comercial = new ComercialVO(1);

            Console.WriteLine(" Se crea con id: " + comercial.Id);

            ComercialBLL comercialDatos = new ComercialBLL();

            Console.WriteLine(comercialDatos.gestionaDatos(comercial));
            gb.comercial = comercialDatos.gestionaDatos(comercial);
            pnSeleccion.Top = btnComercial1.Top;
        }

        private void tlpBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComercial2_Click(object sender, EventArgs e)
        {
            tlp.Controls.Add(gb, 0, 0); // Lo añade en la columna 1, fila 1

            ComercialVO comercial = new ComercialVO(2);

            Console.WriteLine(" Se crea con id: " + comercial.Id);

            ComercialBLL comercialDatos = new ComercialBLL();

            Console.WriteLine(comercialDatos.gestionaDatos(comercial));
            gb.comercial = comercialDatos.gestionaDatos(comercial);

            pnSeleccion.Top = btnComercial2.Top;
        }

        private void btnComercial3_Click(object sender, EventArgs e)
        {
            tlp.Controls.Add(gb, 0, 0); // Lo añade en la columna 1, fila 1

            ComercialVO comercial = new ComercialVO(3);

            Console.WriteLine(" Se crea con id: " + comercial.Id);

            ComercialBLL comercialDatos = new ComercialBLL();

            Console.WriteLine(comercialDatos.gestionaDatos(comercial));
            gb.comercial = comercialDatos.gestionaDatos(comercial);
        }
    }
}
