using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Monitor
    {
        private string dimensiones;
        private string resolucion;
        private string tipoPanel;
        private string modelo;
        private string anoFabricación;
        private string marca;
        public string Dimensiones
        {
            get { return dimensiones; }
            set { dimensiones = value; }
        }
        public string Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }
        public string TipoPanel
        {
            get { return tipoPanel; }
            set { tipoPanel = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string AnoFabricacion
        {
            get { return anoFabricación; }
            set { anoFabricación = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Mostrar()
        {
            return "El método mostrar recién será implementado";
        }
        public string Encender()
        {
            return "El método encender recién será implementado";
        }
        public string Apagar()
        {
            return "El método apagar recién será implementado";
        }

    }
}