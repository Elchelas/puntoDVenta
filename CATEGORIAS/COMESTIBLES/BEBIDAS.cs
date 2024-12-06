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
    public partial class BEBIDAS : Form
    {
        public BEBIDAS()
        {
            InitializeComponent();
        }

        SLCT slct = new SLCT();
        private void button1_Click(object sender, EventArgs e)
        {
            string idCategoria = "COM2";
            slct.MostrarProductosPorCategoria(idCategoria, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
