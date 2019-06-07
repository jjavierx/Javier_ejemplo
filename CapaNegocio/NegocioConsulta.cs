using CapaConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class NegocioConsulta
    {

        private Conexion conec;

        public Conexion Conec { get => conec; set => conec = value; }


        public void configurarConexion()
        {
            this.Conec = new Conexion();
            this.Conec.NombreBaseDeDatos = "Prueba";
            this.Conec.NombreTabla = "Consulta_stock";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-CRFJL0B1\\BLACKCATSQL;Initial Catalog=Prueba;Integrated Security=True";
        }

        public void AgregarProducto(ConsultaStock consultaStock)

        {

            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO Consulta_stock "
                        + "(sku, cantidad) "
                        + "VALUES "
                        + "('" + consultaStock.Sku + "','"
                        + consultaStock.Cantidad + "');";
            this.conec.EsSelect = false;
            this.conec.conectar();

        }

        public DataSet BuscarStock(String sku)

        {

            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT cantidad FROM Consulta_stock" +
                                    " WHERE sku = '" + sku + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;

        }

        public void ActualizarStock(ConsultaStock consultaStock)

        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE Consulta_stock "
                                   + " SET cantidad = '" + consultaStock.Cantidad
                                   + "' WHERE sku = '" + consultaStock.Sku + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();

        } //Fin actualizar stock

        public ConsultaStock BuscarProducto(String sku)

        {

            ConsultaStock auxConsultaStock = new ConsultaStock();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM Consulta_stock" +
                                    " WHERE sku = '" + sku + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[this.Conec.NombreTabla];

            try
            {
                auxConsultaStock.Sku = (String)dt.Rows[0]["sku"];
            }
            catch (Exception ex)
            {
                auxConsultaStock.Sku = "";
            }

            return auxConsultaStock;
        }
    }
}