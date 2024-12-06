using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace puntoDVenta.INVENTARIO
{
    public partial class ELIMINAR : Form
    {
        public ELIMINAR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        eliminarProducto eliminar = new eliminarProducto();
        private void button2_Click(object sender, EventArgs e)
        {
            int IDproducto = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;

            eliminar.EliminarProducto(IDproducto, nombre, label3);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
