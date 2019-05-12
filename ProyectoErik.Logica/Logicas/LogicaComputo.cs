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
        private RepositorioComputo _repositorioComputo;

        public LogicaComputo()
        {
            _repositorioComputo = new RepositorioComputo();
        }

        public void InsertarComputoyMarca(Computo computo)
        {
            _repositorioComputo.InsertarComputoyMarca(computo);
        }
    }
}
