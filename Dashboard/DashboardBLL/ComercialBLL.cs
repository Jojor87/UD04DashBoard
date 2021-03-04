using DashboardDAL;
using System;
using UtilidadesDashboard;

namespace DashboardBLL
{
    public class ComercialBLL
    {
        // constructor() {}
        public ComercialBLL()
        {

        }

        public string gestionaDatos(ComercialVO comercial)
        {

            ComercialDAL comercialDatos = new ComercialDAL();
            comercialDatos.leerDatosComercial(comercial);

            return comercial.ToString();
        }

        public string gestionaFactura(Facturacion  factura)
        {

            ComercialDAL comercialDatos = new ComercialDAL();
            comercialDatos.leerFacturacionComercial(factura);

            return factura.ToString();
        }
    }
}
