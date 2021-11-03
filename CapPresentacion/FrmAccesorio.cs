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
    public partial class FrmAccesorio : Form
    {
        public FrmAccesorio()
        {
            InitializeComponent();
        }
        Accesorio accesorio = new Accesorio();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string teclado = txtTeclado.Text.Trim();
            string camaraWeb = txtCamaraWeb.Text.Trim();
            string impresora = txtImpresora.Text.Trim();
            string audifonos = txtAudifonos.Text.Trim();
            string parlantes = txtParlantes.Text.Trim();
            string mouse = txtMouse.Text.Trim();
            accesorio.Teclado = teclado;
            accesorio.CamaraWeb = camaraWeb;
            accesorio.Impresora = impresora;
            accesorio.Audifonos = audifonos;
            accesorio.Parlantes = parlantes;
            accesorio.Mouse = mouse;
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            txtTeclado.Clear();
            txtCamaraWeb.Clear();
            txtImpresora.Clear();
            txtAudifonos.Clear();
            txtParlantes.Clear();
            txtMouse.Clear();
            txtTeclado.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string teclado = accesorio.Teclado;
            string camaraWeb = accesorio.CamaraWeb;
            string impresora = accesorio.Impresora;
            string audifonos = accesorio.Audifonos;
            string parlantes = accesorio.Parlantes;
            string mouse = accesorio.Mouse;
            MessageBox.Show("Datos del accesorio" + "\n" + "Teclado:" + teclado + "\n" + "Camara Web:" + camaraWeb + "\n" +
                "Impresora:" + impresora + "\n" + "Audifonos:" + audifonos + "\n" + "Parlantes:" + parlantes + "\n" + "Mouse:" +
                mouse);

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accesorio.Enviar());
        }
        private void btnRecibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accesorio.Recibir());
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accesorio.Ejecutar());
        }
        private void btnComplementar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accesorio.Complementar());
        }
    }
}