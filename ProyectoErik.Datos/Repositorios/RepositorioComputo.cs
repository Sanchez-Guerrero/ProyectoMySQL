using MySql.Data.MySqlClient;
using ProyectoErik.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoErik.Datos.Repositorios
{
    public class RepositorioComputo
    {
        string ConnectionString = @"Server=localhost;Database=servicedbdistribuidos;Uid=root;pwd=moises;";//Cadena de conexion a MySQL.
        //Creación de stored procedure para poder realizar la inserción. 
        public void InsertarComputoyMarca(Computo computo)
        {
            try
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(ConnectionString))
                {
                    mysqlConnection.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("st_RegistrarComputo", mysqlConnection);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_descripcion", computo.descripcion);
                    mySqlCmd.Parameters.AddWithValue("_observaciones", computo.observaciones);
                    mySqlCmd.Parameters.AddWithValue("_numeroSerie", computo.numeroSerie);
                    mySqlCmd.Parameters.AddWithValue("_color", computo.color);
                    mySqlCmd.Parameters.AddWithValue("_procesador", computo.procesador);
                    mySqlCmd.Parameters.AddWithValue("_numeroMac", computo.numeroMac);
                    mySqlCmd.Parameters.AddWithValue("_display", computo.display);
                    mySqlCmd.Parameters.AddWithValue("_nombreComercial", computo.nombreComercial);
                    mySqlCmd.Parameters.AddWithValue("_nombre", computo.nombre);
                    mySqlCmd.Parameters.AddWithValue("_descripcionMarca", computo.descripcionMarca);
                    mySqlCmd.ExecuteNonQuery();
                };
            }
            catch(MySqlException ex)
            {
                ex.ToString();
            }
        }
    }
}
