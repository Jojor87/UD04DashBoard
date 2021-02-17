using System;
using UtilidadesDashboard;
using DashboardBLL;

namespace UIConsola
{
    class LecturaConsola
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige comercial: \n" +
                "1- Comercial 1\n" +
                "2- Comercial 2 \n" +
                "3- Comercial 3");

            // Se pide por teclado valor y se parsea a valor entero ya que viene como string
            int comercialID = int.Parse(Console.ReadLine());

            Console.WriteLine(" Se elige comercial: " + comercialID);

            ComercialVO comercial = new ComercialVO(comercialID);

            Console.WriteLine(" Se crea con id: " + comercial.Id);

            ComercialBLL comercialDatos = new ComercialBLL();

            Console.WriteLine(comercialDatos.gestionaDatos(comercial));

        }
    }
}
