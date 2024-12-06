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
    public partial class HOGAR : Form
    {
        public HOGAR()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MUEBLES MUEBLESForm = new  MUEBLES();

            MUEBLESForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VAJILLA VAJILLAForm = new VAJILLA();

            VAJILLAForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DECORACION DECORACIONForm = new DECORACION();

            DECORACIONForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ELECTRODOMESTICOS ELECTRODOMESTICOSForm = new ELECTRODOMESTICOS();

            ELECTRODOMESTICOSForm.Show();
        }
    }
}
