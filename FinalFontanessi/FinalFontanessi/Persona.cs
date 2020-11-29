using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public abstract class Persona
    {
        //DNI, Nombre, Apellido, Teléfono, Dirección y Localidad. 
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public Localidad LocalidadP { get; set; }
        public virtual string ObtenerDetalle()
        {
            //Corrección: siempre es mejor utilizar interpolación.
            return Apellido + "," + Nombre + "-" + "Telefono:" + "," + Telefono.ToString() + "-" +
            LocalidadP.Provincia + "," + LocalidadP.NombreLocalidad + "," + Direccion;

        }
        public abstract string FestejarNuevoAnio();
    }
}
