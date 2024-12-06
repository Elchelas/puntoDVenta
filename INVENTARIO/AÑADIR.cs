using puntoDVenta.INVENTARIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace puntoDVenta.CATEGORIAS
{
    public partial class AÑADIR : Form
    {
        public AÑADIR()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AÑADIR_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        añadirProducto añadir = new añadirProducto();

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            string nombre = textBox1.Text;            
            string descripcion = textBox2.Text;       
            int stock = int.Parse(textBox3.Text);
            double precio = double.Parse(textBox4.Text); 
            string idCategoria = textBox5.Text;

            if (nombre == "" || descripcion == "" || stock < 0 || precio < 0 || idCategoria == "")
            {
                label7.Text = "se deben completar todos los datos";
                return;
            }

            if (idCategoria == "COM1" || idCategoria == "COM2" || idCategoria == "COM3" || idCategoria == "COM4" || idCategoria == "COM5" ||
                        idCategoria == "HOG1" || idCategoria == "HOG2" || idCategoria == "HOG3" || idCategoria == "HOG4" ||
                        idCategoria == "LIM1" || idCategoria == "LIM2" || idCategoria == "LIM3" || idCategoria == "LIM4" ||
                        idCategoria == "REF1" || idCategoria == "REF2" || idCategoria == "REF3" || idCategoria == "REF4" ||
                        idCategoria == "MAS1" || idCategoria == "MAS2" || idCategoria == "MAS3" || idCategoria == "MAS4" ||
                        idCategoria == "TEC1" || idCategoria == "TEC2" || idCategoria == "TEC3" || idCategoria == "TEC4"

                        )
            {

                if (nombre != "" && descripcion != "" && stock >= 0 && precio >= 0 && idCategoria != "")
                {
                    añadir.añadirProductos(nombre, descripcion, stock, precio, idCategoria);
                    label7.Text = "Registro exitoso!";
                    return;
                }
            }
            else {
                label7.Text = "esa categoria no existe.";
                return;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
