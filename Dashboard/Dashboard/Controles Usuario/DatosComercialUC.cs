using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Controles_Usuario
{
    public partial class DatosComercialUC : UserControl
    {
        public DatosComercialUC()
        {
            InitializeComponent();
        }

        public void pintaTextBox(string comercial) 
        {
            tbComercial.Text = comercial;
        }

        public void pintaTextBoxFacturacion(string factura1, string factura2)
        {
            tbComercial.Text = factura1 + " y " + factura2;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //tbComercial.Text = comercial;
        }
    }
}
