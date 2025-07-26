using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string horaActual = DateTime.Now.ToString("HH:mm:ss"); 
            string fechaActual = DateTime.Now.ToLongDateString();

            lblSaludo.Text = $"Hola {nombre}, ¡Saludos y que tengas un exelente dia!.";
            lblFechaHora.Text = $"Hoy es  {fechaActual}, y son las  {horaActual}. ";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaHora_Click(object sender, EventArgs e)
        {

        }
    }
}
