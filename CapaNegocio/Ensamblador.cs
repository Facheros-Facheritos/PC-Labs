using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ensamblador : Empleado
    {
        private string componentesUsados;
        public string ComponentesUsados
        {
            get { return componentesUsados; }
            set { componentesUsados = value; }
        }
        public string Ensamblar()
        {
            return "El metodo ensamblar recien sera implementado";
        }
        public string Ordenar()
        {
            return "El metodo encender recien sera implementado";
        }
        public string Contar()
        {
            return "El metodo contar recien sera implementado";
        }
    }
}
