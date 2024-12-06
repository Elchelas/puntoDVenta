using MySql.Data.MySqlClient;
using puntoDVenta.LOGGEOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace puntoDVenta
{
    public partial class agregarEmp : Form
    {
        public agregarEmp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarEmp_Load(object sender, EventArgs e)
        {

        }

        metodosValidacion validacion = new metodosValidacion();

        private void button1_Click(object sender, EventArgs e)
        {
            string empleado = textBox1.Text;
            string claveEmp = textBox2.Text;
            string ConfclaveEmp = textBox2.Text;
            string claveMa = textBox4.Text;
            string rango = textBox5.Text;

             if(claveEmp != ConfclaveEmp)
            {
                label5.Text = "Las claves no coinciden.";
                return;
            }

            if (claveMa != "puntoDVenta")
            {
                label5.Text = "La clave Maestra no es correcta.";
                return;
            }

            // Encriptar la contraseña y almacenarla en la base de datos
            string claveHa = validacion.HashClave(ConfclaveEmp);

            //agregar empleado en la base de datos
            validacion.GuardarEmpleadoEnBaseDeDatos(empleado, claveEmp, claveHa, rango);

            MessageBox.Show("Registro exitoso");
            this.Close();  // Cerrar formulario
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();  // Cerrar formulario

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
