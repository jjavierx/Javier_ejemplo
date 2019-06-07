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
    public partial class Registro_salida : Form
    {
        public Registro_salida()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            WebServiceProducto.WebServiceProductoSoapClient auxServicio = new WebServiceProducto.WebServiceProductoSoapClient();

            WebServiceProducto.RegistraSalidaProducto auxRegistrarSalida = new WebServiceProducto.RegistraSalidaProducto();

            if (this.txt_cantidad_salida.Text == "")
            {

                MessageBox.Show("Rellena el campo cantidad de salida", "Sistema");
                return;
        
            }

            if (this.txt_nombre.Text == "")

            {

                MessageBox.Show("Rellena el campo nombre", "Sistema");
                return;

            }

            if (this.txt_salida.Text == "")

            {

                MessageBox.Show("Rellena el campo número de salida", "Sistema");
                return;

            }

            auxRegistrarSalida.Cantidad_salida = Convert.ToInt32(this.txt_cantidad_salida.Text);
            auxRegistrarSalida.Fecha = Convert.ToDateTime(this.Fecha.Text);
            auxRegistrarSalida.Sku = this.txt_nombre.Text;
            auxRegistrarSalida.Numero_salida = Convert.ToInt32(this.txt_salida.Text);

            auxServicio.RegisterSalidaProduct(auxRegistrarSalida);

            MessageBox.Show("Registro de salida guardado exitosamente", "Sistema");

        }

        private void Registro_salida_Load(object sender, EventArgs e)
        {

            // txt_nombre.Text = Fecha.Value.ToShortDateString();
            // Fecha.Value = new DateTime(2001, 10, 20);

            Fecha.Format = DateTimePickerFormat.Short;
            // Fecha.CustomFormat = "dd/MM/yyyy";

        }
    }
}
