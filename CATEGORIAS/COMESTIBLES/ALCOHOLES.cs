using puntoDVenta.CATEGORIAS.METODOS_CATEGORIA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puntoDVenta.CATEGORIAS.COMESTIBLES
{
    public partial class ALCOHOLES : Form
    {
        public ALCOHOLES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SLCT slct = new SLCT();
        private void button2_Click(object sender, EventArgs e)
        {
            string idCategoria = "COM4";
            slct.MostrarProductosPorCategoria(idCategoria, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
