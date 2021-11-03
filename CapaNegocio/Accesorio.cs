using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Accesorio
    {
        private string teclado;
        private string camaraWeb;
        private string impresora;
        private string audifonos;
        private string parlantes;
        private string mouse;
        public string Teclado
        {
            get { return teclado; }
            set { teclado = value; }
        }
        public string CamaraWeb
        {
            get { return camaraWeb; }
            set { camaraWeb = value; }
        }
        public string Impresora
        {
            get { return impresora; }
            set { impresora = value; }
        }
        public string Audifonos
        {
            get { return audifonos; }
            set { audifonos = value; }
        }
        public string Parlantes
        {
            get { return parlantes; }
            set { parlantes = value; }
        }
        public string Mouse
        {
            get { return mouse; }
            set { mouse = value; }
        }
        //Declaración metodo u operación
        public string Enviar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Recibir()
        {
            return "Este metodo recien sera implementado";
        }
        public string Ejecutar()
        {
            return "Este metodo recien sera implementado";
        }
        public string Complementar()
        {
            return "Este metodo recien sera implementado";
        }
    }
}
