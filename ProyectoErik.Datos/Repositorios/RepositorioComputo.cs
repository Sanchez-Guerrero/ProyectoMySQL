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
                string Query = "insert into computo(descripcion,observaciones,numeroSerie,color,idMarca,procesador,numeroMac,display,nombreComercial) values('" + computo.descripcion + "','" + computo.observaciones + "','" + computo.numeroSerie + "','" + computo.color + "','" + computo.idMarca + "','" + computo.procesador + "','" + computo.numeroMac + "','" + computo.display + "','" + computo.nombreComercial + "');";  
                MySqlConnection MyConn2 = new MySqlConnection(ConnectionString); 
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
            }
            catch(MySqlException ex)
            {
                ex.ToString();
            }
        }
    }
}
