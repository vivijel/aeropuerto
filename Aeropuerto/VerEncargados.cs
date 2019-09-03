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
    public partial class VerEncargados : Form
    {
        public VerEncargados()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            
            data.DataSource = BD.LEncargados;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            RegistroEncargados RE = new RegistroEncargados("Modificando Encargado", " ");
            RE.ShowDialog();
        }
    }
}
