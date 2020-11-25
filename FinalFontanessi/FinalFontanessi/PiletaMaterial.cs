using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public class PiletaMaterial: Pileta
    {
        //material se conoce su largo, ancho, profundidad, si tiene trampolín y la cantidad de escaleras que tiene la pileta
        public float Largo { get; set; }
        public float Ancho { get; set; }
        public float Profundidad { get; set; }
        public bool TieneTrampolin { get; set; }
        public int CantEscaleras { get; set; }

        public override int PorcentajeDescuento()
        {
            //Para las piletas de material: si la pileta tiene una profundidad mayor a 1,5 metros y tiene trampolín el método deberá devolver el valor 10, de lo contrario devolverá el valor 5.
            if (Profundidad >= 1.5 & TieneTrampolin == true)
            {
                return 10;
            }
            else
            {
                return 5;
            }
        }
    }
}
