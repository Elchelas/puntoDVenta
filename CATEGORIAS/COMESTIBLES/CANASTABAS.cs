﻿using puntoDVenta.CATEGORIAS.METODOS_CATEGORIA;
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
    public partial class CANASTABAS : Form
    {
        public CANASTABAS()
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
            string idCategoria = "COM5";
            slct.MostrarProductosPorCategoria(idCategoria, dataGridView1);
        }
    }
}
