using puntoDVenta.CATEGORIAS.COMESTIBLES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puntoDVenta.CATEGORIAS
{
    public partial class COMESTIBLE : Form
    {
        public COMESTIBLE()
        {
            InitializeComponent();
        }

        private void COMESTIBLES_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SNACKS SNACKSForm = new SNACKS();

            SNACKSForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BEBIDAS BEBIDASForm = new BEBIDAS();

            BEBIDASForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CARNICERIA CARNICERIAForm = new CARNICERIA();

            CARNICERIAForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ALCOHOLES ALCOHOLESForm = new ALCOHOLES();

            ALCOHOLESForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CANASTABAS CANASTABASForm = new CANASTABAS();

            CANASTABASForm.Show();
        }
    }
}
