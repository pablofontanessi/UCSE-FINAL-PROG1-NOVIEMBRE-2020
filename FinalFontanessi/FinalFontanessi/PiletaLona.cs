using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
   public class PiletaLona: Pileta
    {
        //lona se conoce su alto, ancho, profundidad, si viene con filtro y si viene con cubre piletas.
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public float Profundidad { get; set; }
        public bool TieneFiltro { get; set; }
        public bool TieneCubrePileta { get; set; }

        public override int PorcentajeDescuento()
        {
            //Para las piletas de lona: el método debe devolver el valor 8.
            return 8;
        }
    }
}
