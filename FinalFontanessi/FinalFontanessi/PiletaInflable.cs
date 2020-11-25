using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public class PiletaInflable: Pileta
    {
        //inflables se conoce su diámetro, profundidad y si viene con cubre piletas.
        public float Diametro { get; set; }
        public float Profundidad { get; set; }
        public bool TieneCubrePileta { get; set; }

        public override int PorcentajeDescuento()
        {
            return 0;
        }
    }
}
