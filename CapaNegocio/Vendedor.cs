using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vendedor : Empleado 
    {
        private string recordVentas;
        public string RecordVentas
        {
            get { return recordVentas; }
            set { recordVentas = value; }
        }
        public string Vender()
        {
            return "El metodo Vender recien sera implementado";
        }
        public string Convencer()
        {
            return "El metodo Convencer recien sera implementado";
        }
        public string Mostrar()
        {
            return "El metodo Mostrar recien sera implementado";
        }
        public string Guardar()
        {
            return "El metodo Guardar recien sera implementado";
        }
    }
}
