using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la librería que me permite usar comandos para trabajar con bases de datos.
using System.Data.SqlClient; //Esta es la librería  me permite trabajar con SQL Server.


namespace miPrimerProyectoCsharp
{
    internal class Conexion
    {
        //Definir los miembros de la clase, atributos y métodos.
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la base de datos. Lectura, Acualizacion, Eliminación, Insercion.
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la base de datos.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Un puente entre la base de datos y la aplicación.
        DataSet objDS = new DataSet(); //Es una representación de la arquitectura de la base de datos  en  memoria.

        public Conexion() //Constructor, inicializador de los atributos.
        {
           string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexión a la base de datos.
        }
        public DataSet obtenerDatos() 
        {
           objDS.Clear(); //Limpiar el DataSet.
           objComando.Connection = objConexion; //Establecer la conexión para ejecutar los comandos.

           objAdaptador.SelectCommand = objComando; //Establecer el comando de selección.

           objComando.CommandText = "SELECT * FROM Docente";
            
           
            objAdaptador.Fill(objDS, "Docente"); //Tomando los datos  de la base de datos y llenando el DataSet.
            
            return objDS; //Retornar el DataSet con los datos.



        }
        public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Docente(codigo,nombre,direccion,telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Docente SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idDocente=@idDocente";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM Docente WHERE idDocente=@idDocente";
            }
            return ejecutarSQL(sql, datos);
        }
        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idDocente", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
