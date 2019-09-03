using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeropuerto.Clases;

namespace Aeropuerto
{
    public partial class RegistroEncargados : Form
    {
        public RegistroEncargados()
        {
            InitializeComponent();
            btnModificar.Visible = false;
        }
        public RegistroEncargados(String Titulo,String Correo)
        {
            InitializeComponent();
            lblTitulo.Text = Titulo;
            buttonVerRegistros.Visible = false;
            btnRegistrar.Visible = false;

        }

        private void RegistroEncargados_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string email = textBoxCorreo.Text;
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string clave1 = textBoxPass.Text.Trim();
            string clave2 = textBoxRPass.Text.Trim();
            DateTime fecha = dtpFecha.Value;

            if (email.Length < 13)
            {
                MessageBox.Show("Ingrese un mail de 13 caracteres o mas ", "ERROR");
            }else if (nombre.Length < 3)
            {
                MessageBox.Show("El nombre debe tener como minimo 3 caracteres", "ERROR");
            }
            else if (apellido.Length < 3)
            {
                MessageBox.Show("El apellido debe tener como minimo 3 caracteres", "ERROR");
            }
            else if (clave1.Length < 6)
            {
                MessageBox.Show("La contraseña debe contener como minimo 6 caracteres", "ERROR");
            }
            else if (! clave1.Equals(clave2))
            {
                MessageBox.Show("Las claves no coinciden" ,"ERROR");
            }
            else
            {
                //todo OK
                Encargado nuevo = new Encargado(email,nombre,apellido,fecha,clave1);
                BD.LEncargados.Add(nuevo);
                MessageBox.Show(nuevo.Fecha_nacimiento.ToString());
              
            }

        }

        private void buttonVerRegistros_Click(object sender, EventArgs e)
        {
            VerEncargados ve = new VerEncargados();
            ve.ShowDialog();
        }
    }
}

