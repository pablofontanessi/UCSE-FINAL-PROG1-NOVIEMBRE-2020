using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public class Empleado: Persona
    {
        public DateTime FechaNacimiento { get; set; }
        //Corrección: No es un enumerador como se pidió
        public int NroTurno { get; set; } //1- Maniana 2- tarde
        //Corrección: No es un enumerador como se pidió
        public int NroAreaTrabaja { get; set; } // 1- Gerencia 2- Ventas 3- Instalación.

        public override string FestejarNuevoAnio()
        {
            if (FechaNacimiento.Day == DateTime.Today.Day & FechaNacimiento.Month == DateTime.Today.Month)
            {
                return "¡Feliz cumpleaños compañero!";
            }
            return "";
        }

        public override string ObtenerDetalle()
        {
            //Correccíón: Esto debía resolverse con un enumerador.
            string DescTurno = "";
            string DescArea = "";
            switch (NroTurno)
            {
                case 1:
                    DescTurno = "Mañana";
                    break;
                case 2:
                    DescTurno = "Tarde";
                    break;
                default:
                    break;
            }
            switch (NroAreaTrabaja)
            {
                case 1:
                    DescArea = "Gerencia";
                    break;
                case 2:
                    DescArea = "Ventas";
                    break;
                case 3:
                    DescArea = "Instalacion";
                    break;
                default:
                    break;
            }

            return base.ObtenerDetalle() + "Turno: " + DescTurno + "Área: " + DescArea;
        }
        
    }
}
