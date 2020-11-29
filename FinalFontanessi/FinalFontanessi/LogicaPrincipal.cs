using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FinalFontanessi
{
    public class LogicaPrincipal
    {
        List<Persona> ListaPersonas = new List<Persona>();
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Ventas> ListaVentas = new List<Ventas>();
        List<Pileta> ListaPiletas = new List<Pileta>();
     

        public RespuestaVentas RegistrarCompraPileta(int DniCliente, int CodPileta)
        {
            Ventas NuevaVenta = new Ventas();
            //Corrección: Si el código de pileta no existe, el codigo no funciona al usar dicha variable.
            var PiletaComprada = ListaPiletas.Find(x => CodPileta == x.CodPileta);
            //Corrección: Si el dni no existe, el codigo no funciona al usar dicha variable.
            var CompradorPileta = ListaPersonas.Find(x => DniCliente == x.DNI);

            if (CompradorPileta is Empleado)
            {
                NuevaVenta.DniComprador = DniCliente;
                NuevaVenta.FechaVenta = DateTime.Today;
                NuevaVenta.NroVenta = ObtenerNroVenta();
                NuevaVenta.ImporteTotal = PiletaComprada.Precio - (PiletaComprada.Precio * (PiletaComprada.PorcentajeDescuento() / 100));
                ListaVentas.Add(NuevaVenta);
                RespuestaVentas NuevaRespuesta = new RespuestaVentas(true, "El registro se realizó correctamente");
                return NuevaRespuesta;
            }
            else
            {
                if (CompradorPileta is Cliente)
                {
                    foreach (var cliente in ListaClientes)
                    {
                        if (cliente.DNI == DniCliente)
                        {
                            cliente.CodPiletaInstalada = CodPileta;
                            cliente.FechaInstalacion = DateTime.Today;
                            NuevaVenta.DniComprador = DniCliente;
                            NuevaVenta.FechaVenta = DateTime.Today;
                            NuevaVenta.NroVenta = ObtenerNroVenta();
                            NuevaVenta.ImporteTotal = PiletaComprada.Precio;
                           
                            ListaVentas.Add(NuevaVenta);
                            RespuestaVentas NuevaRespuesta = new RespuestaVentas(true, "Se registró la nueva pileta del cliente");
                            return NuevaRespuesta;
                        }
                    }
                }
                else
                {
                    if (CompradorPileta is null) //cliente no existe
                    {
                        Cliente NuevoCliente = new Cliente();
                        NuevoCliente.DNI = DniCliente;
                        NuevoCliente.CodPiletaInstalada = CodPileta;
                        NuevoCliente.FechaInstalacion = DateTime.Today;
                        ListaClientes.Add(NuevoCliente);
                        ListaPersonas.Add(NuevoCliente);
                        NuevaVenta.DniComprador = DniCliente;
                        NuevaVenta.FechaVenta = DateTime.Today;
                        NuevaVenta.ImporteTotal = PiletaComprada.Precio;
                        NuevaVenta.NroVenta = ObtenerNroVenta();
                        RespuestaVentas NuevaRespuesta = new RespuestaVentas(true, "Se dio de alta la venta y el cliente, recuerde que debe completar sus datos");
                        return NuevaRespuesta;
                    }
                }
            }
            RespuestaVentas RespuestaFallo = new RespuestaVentas(false, "No se pudo realizar la operacion.");
            return RespuestaFallo;

        }

        public int ObtenerNroVenta()
        {
            return ListaVentas.Count +1 ;
        }
    }
}
