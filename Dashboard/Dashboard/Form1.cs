using Dashboard.Controles_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            tlp.Controls.Add(gb, 1, 1); // Lo añade en la columna 1, fila 1
            
        }
    }
}
