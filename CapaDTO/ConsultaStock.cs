using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
  public  class ConsultaStock
    {
        //comentando esto para ver que onda el tutorial


        private string sku;
        private int cantidad;

        public string Sku { get => sku; set => sku = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
