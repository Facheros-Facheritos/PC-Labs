using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Comprador
    {
        private string apellidos;
        private string nombres;
        private string direccion;
        private string empresa;
        private string correo;
        private string dni;
        private string celular;
        private string artComprados;
        //propiedades para los atributos
        //propiedades de lectura Get-Getter
        //propiedades de escritura SET-SETTER
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
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string ArtComprados
        {
            get { return artComprados; }
            set { artComprados = value; }
        }
        //declaracion de metodos u operaciones
        public string Comprar()
        {
            return "El metodo comprar recien sera implementado";
        }
        public string Pagar()
        {
            return "El metodo pagar recien sera implementado";
        }
        public string Calificar()
        {
            return "El metodo calificar recien sera implementado";
        }
    }
}
