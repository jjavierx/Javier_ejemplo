using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class ConsultaStock : Form
    {
        public ConsultaStock()
        {
            InitializeComponent();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {

            WebServiceProducto.WebServiceProductoSoapClient auxServicio = new WebServiceProducto.WebServiceProductoSoapClient();

            if (this.txt_buscar.Text == "")
            {

                MessageBox.Show("Rellena el campo de nombre", "Sistema");
                return;

            }

            if (!String.IsNullOrEmpty(auxServicio.BuscarProductoService(this.txt_buscar.Text).Sku))

            {

                this.DataGriewProducto.DataSource = auxServicio.BuscarStockService(this.txt_buscar.Text);
                this.DataGriewProducto.DataMember = "Consulta_stock";

            }

            else

            {

                MessageBox.Show("Este producto no existe en los registros", "Sistema");
                return;

            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            WebServiceProducto.WebServiceProductoSoapClient auxServicio = new WebServiceProducto.WebServiceProductoSoapClient();

            WebServiceProducto.ConsultaStock auxConsu = new WebServiceProducto.ConsultaStock();

            if (this.txt_stock.Text == "")
            {

                MessageBox.Show("Rellena el campo stock");
                return;

            }

            if (this.txt_buscar.Text == "")

            {

                MessageBox.Show("Rellena el campo nombre");
                return;

            }

            if (String.IsNullOrEmpty(auxServicio.BuscarProductoService(this.txt_buscar.Text).Sku))

            {

                MessageBox.Show("Este producto no existe en los registros", "Sistema");
                this.txt_buscar.Focus();
                return;
            
            }

            auxConsu.Cantidad = Convert.ToInt32(this.txt_stock.Text);
            auxConsu.Sku = this.txt_buscar.Text;

            auxServicio.actualizarStockService(auxConsu);

            MessageBox.Show("Datos modificados exitosamente.", "Sistema");

            if ((MessageBox.Show("¿Desea hacer el registro de salida ahora?", "Sistema",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                             == DialogResult.Yes))
            {

                Registro_salida pRegistroSalida = new Registro_salida();
                pRegistroSalida.ShowDialog();
                System.GC.Collect();
                
            }
        }

        private void DataGriewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DataGriewProducto.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_stock.Text = row.Cells[0].Value.ToString();

           }
        }
     }
  }
