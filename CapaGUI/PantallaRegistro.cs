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
    public partial class PantallaRegistro : Form
    {
        public PantallaRegistro()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            WebServiceProducto.WebServiceProductoSoapClient auxServiceProducto = new WebServiceProducto.WebServiceProductoSoapClient();

            WebServiceProducto.ConsultaStock auxConsulta = new WebServiceProducto.ConsultaStock();

            if (this.txt_nombre.Text == "")
            {

                MessageBox.Show("Rellena el campo nombre", "Sistema");
                return;

            }

            if (this.txt_cantidad.Text == "")
            {

                MessageBox.Show("Rellena el campo cantidad", "Sistema");
                return;

            }

            if (!String.IsNullOrEmpty(auxServiceProducto.BuscarProductoService(this.txt_nombre.Text).Sku))

            {
                MessageBox.Show("Este producto ya ha sido registrado", "Sistema");
                this.txt_nombre.Focus();
                return;
            }

            else

            {

                auxConsulta.Sku = this.txt_nombre.Text;
                auxConsulta.Cantidad = Convert.ToInt32(this.txt_cantidad.Text);

                auxServiceProducto.RegisterProduct(auxConsulta);

                MessageBox.Show("Producto registrado con éxito.", "Sistema");

            }
        }
    }
}
