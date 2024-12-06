using puntoDVenta.CATEGORIAS;
using puntoDVenta.CATEGORIAS.HOGAR;
using puntoDVenta.CATEGORIAS.LIMPIEZA;
using puntoDVenta.CATEGORIAS.MASCOTAS;
using puntoDVenta.CATEGORIAS.REFACCIONES;
using puntoDVenta.CATEGORIAS.TECNOLOGIAS;
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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            COMESTIBLE COMESTIBLESForm = new COMESTIBLE();

            COMESTIBLESForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LIMPIEZAS LIMPIEZASForm = new LIMPIEZAS();

            LIMPIEZASForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HOGAR HOGARForm = new HOGAR();

            HOGARForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TECNOLOGIA TECNOLOGIASForm = new TECNOLOGIA();

            TECNOLOGIASForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REFACCION REFACCIONForm = new REFACCION();

            REFACCIONForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MASCOTA MASCOTAForm = new MASCOTA();

            MASCOTAForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
