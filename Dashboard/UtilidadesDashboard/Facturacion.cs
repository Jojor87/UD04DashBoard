using System;
using System.Collections.Generic;
using System.Text;

namespace UtilidadesDashboard
{
    public class Facturacion
    {
        private int id;
        private int empresa;
        public int[] mes = new int[12];

        public Facturacion(int id, int empresa) {
            this.id = id;
            this.empresa = empresa;
        }

        public int Id { get => id; set => id = value; }
        public int Empresa { get => empresa; set => empresa = value; }

        public int total()
        {
            int total = 0;

            foreach (int t in mes) {
                total += t;
            }

            return total;
        }
        //public int[] Mes { get => mes; set => mes = value; }

        public override string ToString()
        {
            string factura;

            factura = " Ha facturado un total de " + total() + "€ " + " para la empresa " + empresa;

            return factura;
        }
    }
}
