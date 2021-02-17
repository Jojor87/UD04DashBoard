using System;
using System.Collections.Generic;
using System.IO;
using UtilidadesDashboard;

namespace DashboardDAL
{
    public class ComercialDAL
    {
        public void leerDatosComercial(ComercialVO comercial)
        {
            try
            {
                var reader = new StreamReader(File.OpenRead(@"..\..\..\DashboardDAL\BD\1_datos_comerciales.csv"));
                // Salta la primera fila del archivo csv
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    // Se recorre todo el contenido de values y se guardan los valores en linea menos la primera columna(el id)
                    for (int i = 1; i < values.Length; i++)
                    {
                        // Si el id es igual al que se le pasa guarda los valores
                        if (comercial.Id == int.Parse(values[0]))
                        {
                            comercial.Nombre = values[1];
                            comercial.Apellido = values[2];
                            comercial.Localidad = values[3];
                            comercial.Edad = int.Parse(values[4]);
                        }
                    }
                }
                reader.Close();
                //return comercial.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Se ha leido correctamente");

            }
            //return "No se ha podido leeer";
        }
    }
}
