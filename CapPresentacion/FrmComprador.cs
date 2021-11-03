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
    public partial class FrmComprador : Form
    {
        public FrmComprador()
        {
            InitializeComponent();
        }
        Comprador comprador = new Comprador();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string empresa = txtEmpresa.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string dni = txtDni.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string artComprados = txtArtComprados.Text.Trim();
            comprador.Apellidos = apellidos;
            comprador.Nombres = nombres;
            comprador.Direccion = direccion;
            comprador.Empresa = empresa;
            comprador.Correo = correo;
            comprador.Dni = dni;
            comprador.Celular = celular;
            comprador.ArtComprados = artComprados;
            MessageBox.Show("Se ha escrito correctamente el objeto");
            txtApellidos.Clear();
            txtNombres.Clear();
            txtDireccion.Clear();
            txtEmpresa.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            txtCelular.Clear();
            txtArtComprados.Clear();
            txtApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombres = comprador.Nombres;
            string apellidos = comprador.Apellidos;
            string direccion = comprador.Direccion;
            string empresa = comprador.Empresa;
            string correo = comprador.Correo;
            string dni = comprador.Dni;
            string celular = comprador.Celular;
            string artComprados = comprador.ArtComprados;
            MessageBox.Show("Datos del comprador:" + "\n" + "Nombres:" + nombres + "\n" + "Apellidos:" + apellidos + "\n" +
                "Dirección:" + direccion + "\n" + "Empresa:" + empresa + "\n" + "Correo:" + correo + "\n" + "DNI:" +
                dni + "\n" + "Celular:" + celular + "\n" + "Articulos comprados:" + artComprados);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comprador.Comprar());
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comprador.Pagar());
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comprador.Calificar());
        }
    }
}
