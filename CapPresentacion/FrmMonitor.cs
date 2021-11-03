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
    public partial class FrmMonitor : Form
    {
        public FrmMonitor()
        {
            InitializeComponent();
        }
        Monitor monitor = new Monitor();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string dimensiones = txtDimensiones.Text.Trim();
            string anoFabricacion = txtAnoFabricacion.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string resolucion = txtResolucion.Text.Trim();
            string tipoPanel = txtTipoPanel.Text.Trim();
            string marca = txtMarca.Text.Trim();
            monitor.AnoFabricacion = anoFabricacion;
            monitor.Dimensiones = dimensiones;
            monitor.Marca = marca;
            monitor.Modelo = modelo;
            monitor.Resolucion = resolucion;
            monitor.TipoPanel = tipoPanel;
            MessageBox.Show("Se ha escrito correctamente el objeto");
            txtAnoFabricacion.Clear();
            txtDimensiones.Clear();
            txtModelo.Clear();
            txtResolucion.Clear();
            txtTipoPanel.Clear();
            txtMarca.Clear();
            txtDimensiones.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string anoFabricacion = monitor.AnoFabricacion;
            string dimensiones = monitor.Dimensiones;
            string marca = monitor.Marca;
            string modelo = monitor.Modelo;
            string resolucion = monitor.Resolucion;
            string tipoPanel = monitor.TipoPanel;
            MessageBox.Show("Datos del Monitor" + "\n" + "Año de fabricación:" + anoFabricacion + "\n" + "Dimensiones:" + dimensiones + "\n" +
            "Marca:" + marca + "\n" + "Modelo:" + modelo + "\n" + "Resolucion:" + resolucion + "\n" + "Tipo de Panel:" + tipoPanel);
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monitor.Mostrar());
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monitor.Encender());
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monitor.Apagar());
        }
    }
}
