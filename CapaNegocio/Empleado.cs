using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Empleado
    {
        private string apellidos;
        private string nombres;
        private string celular;
        private string dni;
        private string correo;
        private string horario;
        private string salario;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public string Caminar()
        {
            return "El metodo caminar recién será implementado";
        }
        public string Trabajar()
        {
            return "El metodo trabajar recién será implementado";
        }
        public string Pensar()
        {
            return "El metodo pensar recién será implementado";
        }
    }
}
