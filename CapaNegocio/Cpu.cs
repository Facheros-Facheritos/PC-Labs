using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cpu
    {
        private string memRAM;
        private string discoDuro;
        private string procesador;
        private string placaBase;
        private string sisRefrigeracion;
        private string tarjeta;
        // Propiedades para los atributos
        public string MemRAM
        {
            get { return memRAM; }
            set { memRAM = value; }
        }
        public string DiscoDuro
        {
            get { return discoDuro; }
            set { discoDuro = value; }
        }
        public string Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }
        public string PlacaBase
        {
            get { return placaBase; }
            set { placaBase = value; }
        }
        public string SisRefrigeracion
        {
            get { return sisRefrigeracion; }
            set { sisRefrigeracion = value; }
        }
        public string Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }
        // Declaracion de metodos u operaciones
        public string Ejecutar()
        {
            return "El metodo ejecutar recien será implementado";
        }
        public string Procesar()
        {
            return "El procesar estudiar recien sera implementado";
        }
        public string Interpretar()
        {
            return "El metodo interpretar recien sera implementado";
        }
        public string Transformar()
        {
            return "El metodo transformar recien sera implementado";
        }
        public string Encender()
        {
            return "El metodo encender recien sera implementado";
        }
        public string Apagar()
        {
            return "El metodo apagar recien sera implementado";
        }

    }
}
