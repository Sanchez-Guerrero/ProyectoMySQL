using MySql.Data.MySqlClient;
using ProyectoErik.Entidades.Entidades;
using ProyectoErik.Logica.Logicas;
using ProyectoErikWin.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErikWin.Controller.RegistroGeneral
{
    public class RegistroGeneralController
    {
        private LogicaComputo _logicaComputo;//Agregamos una referencia a la LogicaComputo.
        public RegistroGeneralController()
        {
            _logicaComputo = new LogicaComputo();//Inyeccion de dependencias.
        }
        /*Creamos el metodo para poder registrar con
        parametro compu, que estos parametros los vamos a traer de la vista*/
        public void RegistrarFormulario(Computo compu)
        {    
            try
            {
                Computo entidadComputo = new Computo
                {
                    descripcion = compu.descripcion,
                    observaciones = compu.observaciones,
                    numeroSerie = compu.numeroSerie,
                    color = compu.color,
                    idMarca = compu.idMarca,
                    procesador = compu.procesador,
                    numeroMac = compu.numeroMac,
                    display = compu.display,
                    nombreComercial = compu.nombreComercial
                };
                _logicaComputo.InsertarComputoyMarca(entidadComputo);
                MessageBox.Show("Se guardo Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardo correctamente");
            }
        }
    }
}
