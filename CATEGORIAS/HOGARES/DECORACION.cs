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

namespace puntoDVenta.CATEGORIAS.HOGAR
{
    public partial class DECORACION : Form
    {
        public DECORACION()
        {
            InitializeComponent();
        }

        private void DECORACION_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SLCT slct = new SLCT();
        private void button1_Click(object sender, EventArgs e)
        {
            string idCategoria = "HOG3";
            slct.MostrarProductosPorCategoria(idCategoria, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
