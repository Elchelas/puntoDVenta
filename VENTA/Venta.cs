using puntoDVenta.VENTA;
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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        metodosVenta met = new metodosVenta();

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IDproducto = int.Parse(textBox1.Text);
            int cantidad = int.Parse(textBox2.Text);

            met.AgregarProducto(IDproducto, cantidad, label12);
            met.CargarProductosEnGrid(dataGridView1);
            met.CalcularTotal();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            met.ConfirmarVenta(label11);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
