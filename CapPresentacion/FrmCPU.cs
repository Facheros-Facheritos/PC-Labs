using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapPresentacion
{
    public partial class FrmCPU : Form
    {
        public FrmCPU()
        {
            InitializeComponent();
        }
        Cpu cpu = new Cpu();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string memRAM = txtMemRAM.Text.Trim();
            string discoDuro = txtDiscoDuro.Text.Trim();
            string procesador = txtProcesador.Text.Trim();
            string placaBase = txtPlacaBase.Text.Trim();
            string sisRefrigeracion = txtSisRefrigeracion.Text.Trim();
            string tarjeta = txtTarjeta.Text.Trim();
            cpu.MemRAM = memRAM;
            cpu.DiscoDuro = discoDuro;
            cpu.Procesador = procesador;
            cpu.PlacaBase = placaBase;
            cpu.SisRefrigeracion = sisRefrigeracion;
            cpu.Tarjeta = tarjeta;
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            txtMemRAM.Clear();
            txtDiscoDuro.Clear();
            txtProcesador.Clear();
            txtPlacaBase.Clear();
            txtSisRefrigeracion.Clear();
            txtTarjeta.Clear();
            txtMemRAM.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string memRAM = cpu.MemRAM;
            string discoDuro = cpu.DiscoDuro;
            string procesador = cpu.Procesador;
            string placaBase = cpu.PlacaBase;
            string sisRefrigeracion = cpu.SisRefrigeracion;
            string tarjeta = cpu.Tarjeta;
            MessageBox.Show("Datos del CPU" + "\n" + 
                            "Memoria RAM: " + memRAM + "\n" +
                            "Disco Duro: " + discoDuro + "\n" + 
                            "Procesador: " + procesador + "\n" +
                            "Placa Base: " + placaBase + "\n" + 
                            "Sistema Refriger.: " + sisRefrigeracion + 
                            "\n" + "Tarjeta: " + tarjeta);
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cpu.Ejecutar());
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cpu.Procesar());
        }
        private void btnInterpretar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cpu.Interpretar());
        }
        private void btnTransformar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cpu.Transformar());
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cpu.Encender());
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cpu.Apagar());
        }
    }
}
