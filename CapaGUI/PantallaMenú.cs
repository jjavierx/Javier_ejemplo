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
    public partial class PantallaMenú : Form
    {
        public PantallaMenú()
        {
            InitializeComponent();
        }

        private void consultarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConsultaStock pConsuStock = new ConsultaStock();
            pConsuStock.ShowDialog();
            System.GC.Collect();

        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PantallaRegistro pRegistro = new PantallaRegistro();
            pRegistro.ShowDialog();
            System.GC.Collect();
           
        }
    }
}
