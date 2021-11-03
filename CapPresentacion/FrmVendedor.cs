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
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }
        Vendedor vendedor = new Vendedor();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string salario = txtSalario.Text.Trim();
            string recordVentas = txtRecordVentas.Text.Trim();
            vendedor.Apellidos = apellidos;
            vendedor.Nombres = nombres;
            vendedor.Celular = celular;
            vendedor.Dni = dni;
            vendedor.Correo = correo;
            vendedor.Horario = horario;
            vendedor.Salario = salario;
            vendedor.RecordVentas = recordVentas;
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtDni.Clear();
            txtCorreo.Clear(); ;
            txtHorario.Clear();
            txtSalario.Clear();
            txtRecordVentas.Clear();
            txtApellidos.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = vendedor.Apellidos;
            string nombres = vendedor.Nombres;
            string celular = vendedor.Celular;
            string dni = vendedor.Dni;
            string correo = vendedor.Correo;
            string horario = vendedor.Horario;
            string salario = vendedor.Salario;
            string recordVentas = vendedor.RecordVentas;
            MessageBox.Show("Datos del Vendedor" + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Nombres: " + nombres + "\n" + "Celular: " + celular + "\n" +
                            "DNI: " + dni + "\n" + "Correo: " +
                            correo + "\n" + "Horario: " + horario + "\n" + "Salario: " +
                            salario + "\n" + "RecordVentas: " + recordVentas);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Vender());
        }

        private void btnConvencer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Convencer());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Mostrar());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vendedor.Guardar());
        }
    }
}
