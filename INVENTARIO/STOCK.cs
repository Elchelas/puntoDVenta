using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puntoDVenta.INVENTARIO
{
    public partial class STOCK : Form
    {
        public STOCK()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        modificarStock stock = new modificarStock();
        private void button2_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(textBox1.Text);
            int nuevoStock = int.Parse(textBox2.Text);


            stock.ModificarStock(idProducto, nuevoStock, label3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
