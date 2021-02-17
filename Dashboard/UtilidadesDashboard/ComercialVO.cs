using System;

namespace UtilidadesDashboard
{
    public class ComercialVO
    {
        private int id;
        private string nombre;
        private string apellido;
        private string localidad;
        private int edad;

        public ComercialVO(int id) {
            this.id = id;
        }

        // Métodos setters and getters
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Edad { get => edad; set => edad = value; }

        // Se reescribe método toString para que muestre segun se quiere
        public override string ToString()
        {
            string datos;

            datos = "DATOS DEL COMERCIAL " + id + 
                "\n NOMBRE:" + nombre + 
                "\n APELLIDO:" + apellido +
                "\n LOCALIDAD:" + localidad +
                "\n EDAD: " + edad;

            return datos;
        }
    }
}
