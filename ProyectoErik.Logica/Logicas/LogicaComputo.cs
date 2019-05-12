using ProyectoErik.Datos.Repositorios;
using ProyectoErik.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoErik.Logica.Logicas
{
    public class LogicaComputo
    {
        private RepositorioComputo _repositorioComputo;//Creamos un objeto de tipo RepositorioComputo.

        public LogicaComputo()//Se inicializa un constructor.
        {
            _repositorioComputo = new RepositorioComputo();//Se crea una inyeccion de dependencias.
        }

        public void InsertarComputoyMarca(Computo computo)//Aquí se realiza la logica para poder insertar.
        {
            _repositorioComputo.InsertarComputoyMarca(computo);
        }
    }
}
