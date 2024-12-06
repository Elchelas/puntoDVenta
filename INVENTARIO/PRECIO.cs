using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puntoDVenta.INVENTARIO.METODOS_INVENTARIO
{
    public partial class PRECIO : Form
    {
        public PRECIO()
        {
            InitializeComponent();
        }

        private void PRECIO_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        cambiarPrecio precio = new cambiarPrecio();
        private void button2_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(textBox1.Text);
            double nuevoPrecio = double.Parse(textBox2.Text);

            precio.ModificarPrecio(idProducto, nuevoPrecio, label3);
        }
    }
}
