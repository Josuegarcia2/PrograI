using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaHora_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;

            num1 = Double.Parse(txtnum1.Text);

            num2 = Double.Parse(txtnum2.Text);

            if (optSuma.Checked)
            {
                respuesta = num1 + num2;

            }
             if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }
            
             if (optMultiplicacion.Checked)  {
                
                respuesta = num1 * num2;


             }

             if (optDivision.Checked)  {
                respuesta = num1 / num2;


             }
             if(optExponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);

            }

             if (optPorcentaje.Checked)
            {
                respuesta = (num1 * num2) / 100;
            }

            
            lblrespuesta.Text = "Respuesta:" + respuesta;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);


            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;

                case 1:
                    respuesta = num1 - num2;
                    break;

                case 2:
                    respuesta = num1 * num2;
                    break;

                case 3:
                    respuesta = num1 / num2;
                    break;

                case 4:
                    respuesta = Math.Pow(num1, num2);
                    break;

                case 5:
                    respuesta = (num1 * num2) / 100;
                    break;

                case 6:
                    respuesta = num1 % num2; // Módulo
                    break;

            }
            lblrespuesta.Text = "respuesta" + respuesta;
        }
    }
}
