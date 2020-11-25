using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public abstract class Pileta
    {
        //Se conoce el código de la pileta, la cantidad de litros que puede contener la pileta, precio y el color de la misma. 
        public int CodPileta { get; set; }
        public int CantidadLitros { get; set; }
        public float Precio { get; set; }
        public int ColorPileta { get; set; } //1- Azul 2-Celeste 3-Gris

        public abstract int PorcentajeDescuento();
    }
}
