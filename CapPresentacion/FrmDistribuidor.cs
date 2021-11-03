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
    public partial class FrmDistribuidor : Form
    {
        public FrmDistribuidor()
        {
            InitializeComponent();
        }
        Distribuidor distribuidor = new Distribuidor();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string salario = txtSalario.Text.Trim();
            string movilidad = txtMovilidad.Text.Trim();
            distribuidor.Apellidos = apellidos;
            distribuidor.Nombres = nombres;
            distribuidor.Celular = celular;
            distribuidor.Dni = dni;
            distribuidor.Correo = correo;
            distribuidor.Horario = horario;
            distribuidor.Salario = salario;
            distribuidor.Movilidad = movilidad;
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtHorario.Clear();
            txtSalario.Clear();
            txtMovilidad.Clear();
         }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = distribuidor.Apellidos;
            string nombres = distribuidor.Nombres;
            string celular = distribuidor.Celular;
            string dni = distribuidor.Dni;
            string correo = distribuidor.Correo;
            string horario = distribuidor.Horario;
            string salario = distribuidor.Salario;
            string movilidad = distribuidor.Movilidad;
            MessageBox.Show("Datos del distribuidor" + "\n" + "Apellidos: " + apellidos + "\n" +
                            "Nombres: " + nombres + "\n" + "Celular: " + celular + "\n" +
                            "DNI: " + dni + "\n" + "Correo: " +
                            correo + "\n" + "Horario: " + horario + "\n" + "Salario: " +
                            salario + "\n" + "Movilidad: " + movilidad);
        }
        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Distribuir());
        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Cobrar());
        }
        private void btnEntregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(distribuidor.Entregar());
        }

    }
}
