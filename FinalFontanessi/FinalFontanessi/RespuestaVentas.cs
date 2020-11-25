using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public class RespuestaVentas
    {
        public bool ExitoONo { get; set; }
        public string MensajeVenta { get; set; }

        public RespuestaVentas (bool Exito, string Mensaje)
        {
            ExitoONo = Exito;
            MensajeVenta = Mensaje;

        }
    }
}
