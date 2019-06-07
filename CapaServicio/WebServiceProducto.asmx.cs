using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaDTO;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/", Description = "Este webservice hace método para la eficiencia en negocio que usan productos en grandes cantidades.")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProducto : System.Web.Services.WebService
    {

        [WebMethod(Description = "Este método registra los productos")]
        public void RegisterProduct(ConsultaStock consultastock)

        {

            NegocioConsulta auxNegocio = new NegocioConsulta();

            auxNegocio.AgregarProducto(consultastock);

        }

        [WebMethod(Description = "Este método registra la salida de los productos")]
        public void RegisterSalidaProduct(RegistraSalidaProducto RegistrarSalida)

        {

            NegocioRegistraSalidaProducto auxNegocio = new NegocioRegistraSalidaProducto();

            auxNegocio.RegistrarSalida(RegistrarSalida);

        }

        [WebMethod(Description = "Este método consulta el stock de los productos")]
        public DataSet BuscarStockService(String sku)

        {

            NegocioConsulta auxNegocio = new NegocioConsulta();

            return auxNegocio.BuscarStock(sku);

        }

        [WebMethod(Description = "Este método actualizar el stock del producto")]
        public void actualizarStockService(ConsultaStock consultaStock)

        {

            NegocioConsulta auxNegocio = new NegocioConsulta();
            auxNegocio.ActualizarStock(consultaStock);

        }

        [WebMethod(Description = "Este método valida el nombre de un producto")]
        public ConsultaStock BuscarProductoService(String sku)
        {

            NegocioConsulta auxNegocio = new NegocioConsulta();

            return auxNegocio.BuscarProducto(sku);

        }
    }
}
