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

           objComando.CommandText = "SELECT * FROM Alumnos"; 
           objAdaptador.Fill(objDS, "Alumnos"); //Tomando los datos  de la base de datos y llenando el DataSet.

           return objDS; //Retornar el DataSet con los datos.



        }

    }
}
