using Microsoft.Win32;
using puntoDVenta.LOGGEOS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace puntoDVenta
{
    public partial class logIN : Form
    {
        public logIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de registro
            agregarEmp agregarEmpForm = new agregarEmp();

            // Mostrar el formulario de registro
            agregarEmpForm.Show();
        }

        metodosValidacion validacion = new metodosValidacion();

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string claveEmp = textBox2.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(claveEmp))
            {
                label3.Text = "Por favor, ingrese usuario y contraseña.";
                return;
            }

            validacion.ValidarEmpleado(nombre, claveEmp);

            if (validacion.ValidarEmpleado(nombre, claveEmp))
            {
                // Abrir el menú principal si es válido
                Menú MenúForm = new Menú();
                MenúForm.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Usuario o contraseña incorrectos.";
            }
        }

        private void logIN_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
