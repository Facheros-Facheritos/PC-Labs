using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Distribuidor : Empleado
    {
        //declaracion de atributos
        private string movilidad;
        //propiedades para los atributos
        //propiedades de lectura Get-Getter
        //propiedades de escritura SET-SETTER
        public string Movilidad
        {
            get { return movilidad; }
            set { movilidad = value; }
        }
        //declaracion de metodos u operaciones
        public string Distribuir()
        {
            return "Este metodo recien sera implementado";
        }
        public string Cobrar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Entregar()
        {
            return "Este metodo recien sera implementado";
        }
    }
}
