using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class NegocioRegistraSalidaProducto
    {

        private Conexion conec;

        public Conexion Conec { get => conec; set => conec = value; }


        public void configurarConexion()
        {
            this.Conec = new Conexion();
            this.Conec.NombreBaseDeDatos = "Prueba";
            this.Conec.NombreTabla = "Registra_salida_producto";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-CRFJL0B1\\BLACKCATSQL;Initial Catalog=Prueba;Integrated Security=True";
        }

        public void RegistrarSalida(RegistraSalidaProducto RegistrarSalida)

        {

            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO Registra_salida_producto "
                        + "(numero_salida, fecha, sku, cantidad_salida) "
                        + "VALUES "
                        + "('" + RegistrarSalida.Numero_salida + "','"
                        + RegistrarSalida.Fecha + "','"
                        + RegistrarSalida.Sku + "','"
                        + RegistrarSalida.Cantidad_salida + "');";
            this.conec.EsSelect = false;
            this.conec.conectar();

        }
    }
}
