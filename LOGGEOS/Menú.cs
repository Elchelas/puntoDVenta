using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puntoDVenta
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Inventario InventarioForm = new Inventario();

            InventarioForm.Show();
        }

        private void Menú_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Categorias CategoriasForm = new Categorias();

            CategoriasForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Venta VentaForm = new Venta();

            VentaForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orden OrdenForm = new Orden();

            OrdenForm.Show();
        }
    }
}
