using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
   public class RegistraSalidaProducto
    {

        private int numero_salida;
        private DateTime fecha;
        private int cantidad_salida;
        private string sku;

        public int Numero_salida { get => numero_salida; set => numero_salida = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Cantidad_salida { get => cantidad_salida; set => cantidad_salida = value; }
        public string Sku { get => sku; set => sku = value; }
    }
}
