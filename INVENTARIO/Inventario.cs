using puntoDVenta.CATEGORIAS;
using puntoDVenta.INVENTARIO;
using puntoDVenta.INVENTARIO.METODOS_INVENTARIO;
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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AÑADIR AÑADIRForm = new AÑADIR();

            AÑADIRForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ELIMINAR ELIMINARForm = new ELIMINAR();

            ELIMINARForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            STOCK STOCKForm = new STOCK();

            STOCKForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NOMBRE NOMBREForm = new NOMBRE();

            NOMBREForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRECIO PRECIOForm = new PRECIO();

            PRECIOForm.Show();
        }
    }
}
