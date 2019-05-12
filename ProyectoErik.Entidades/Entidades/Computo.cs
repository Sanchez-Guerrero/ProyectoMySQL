using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoErik.Entidades.Entidades
{
    /*Se crea la tabla y los atributos, tambien obtenemos los atributos 
    de la tabla marca; ya que estas tablas se encuentran relacionadas.*/
    public class Computo
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
        public string numeroSerie { get; set; }
        public string color { get; set; }
        public int idMarca { get; set; }
        public string nombre { get; set; }
        public string descripcionMarca { get; set; }
        public string procesador { get; set; }
        public string numeroMac { get; set; }
        public string display { get; set; }
        public string nombreComercial { get; set; }
    }
}
