using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public class Cliente: Persona
    {

        public int CodPiletaInstalada { get; set; }
        public DateTime FechaInstalacion { get; set; }

        public override string FestejarNuevoAnio()
        {
            var DiferenciaDias = DateTime.Today - FechaInstalacion;
            if (DiferenciaDias.TotalDays == 365 | DiferenciaDias.TotalDays == 366)
            {
                return "¡Felicitaciones por su primer aniversario de instalación!";
            }
            return "";
        }
       
    }
}
