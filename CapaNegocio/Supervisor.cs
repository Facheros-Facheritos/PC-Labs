using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Supervisor : Empleado
    {
        private string areaSupervisada;
        public string AreaSupervisada
        {
            get { return areaSupervisada; }
            set { areaSupervisada = value; }
        }

        public string Supervisar()
        {
            return "El metodo supervisar recien será implementado";
        }

        public string Informar()
        {
            return "El metodo informar recien será implementado";
        }

        public String Controlar()
        {
            return "El metodo controlar recien será implementado";
        }

        public string Autorizar()
        {
            return "El metodo autorizar recien será implementado";
        }
    }
}
