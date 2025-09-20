using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

        Conexion objconexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";


        private void ActualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet.
            objDs = objconexion.obtenerDatos(); 
            objDt = objDs.Tables["docente"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };

            grdDocentes.DataSource = objDt.DefaultView;

            mostrarDatos();

        }
        private void mostrarDatos()
        {
           if (objDt.Rows.Count > 0)
           {
               idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
               txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
               txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
               txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
               txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();


                lblnRegistrosDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           ActualizarDs();
        }

        

        
            

       

        private void estadoControles(Boolean estado)
        {
            grbDatosDocentes.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;


            grdDocentes.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }


       


        
        private void txtBuscarDocentes_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocentes.Text);
          
        }

        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdDocentes.DataSource = objDv;
            seleccionarDocente();

        }

        private void seleccionarDocente()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocentes.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }

        private void grdDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }

        private void btnPrimerDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {

            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocente.Text == "nuevo")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();

            }
            else
            {//Guardar
                String[] Docente = {
                    idDocente.Text, txtCodigoDocente.Text, txtNombreDocente.Text, txtDireccionDocente.Text,
                    txtTelefonoDocente.Text
                };
                String respuesta = objconexion.administrarDatosDocentes(Docente, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    ActualizarDs();
                }
            }

        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "nuevo";
                btnModificarDocente.Text = "modificar";

            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocente.Text,
               "Eliminando Docentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objconexion.administrarDatosDocentes(
                    new String[] { idDocente.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar Docentes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    ActualizarDs();
                }
            }
        }
    }
}
    
    

    



    

