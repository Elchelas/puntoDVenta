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
    public partial class NOMBRE : Form
    {
        public NOMBRE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NOMBRE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        cambiarNombre nombre = new cambiarNombre();
        private void button2_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(textBox1.Text);
            string nuevoNombre = textBox2.Text;

            nombre.ModificarNombre(idProducto, nuevoNombre, label3);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
