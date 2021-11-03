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
    public partial class FrmSupervisor : Form
    {
        public FrmSupervisor()
        {
            InitializeComponent();
        }
        Supervisor supervisor = new Supervisor();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string salario = txtSalario.Text.Trim();
            string areaSupervisada = txtAreaSupervisada.Text.Trim();
            supervisor.Apellidos = apellidos;
            supervisor.Nombres = nombres;
            supervisor.Celular = celular;
            supervisor.Dni = dni;
            supervisor.Correo = correo;
            supervisor.Horario = horario;
            supervisor.Salario = salario;
            supervisor.AreaSupervisada = areaSupervisada;
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtHorario.Clear();
            txtSalario.Clear();
            txtAreaSupervisada.Clear();
            txtApellidos.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            String apellidos = supervisor.Apellidos;
            String nombres = supervisor.Nombres;
            String celular = supervisor.Celular;
            String dni = supervisor.Dni;
            String correo = supervisor.Correo;
            String horario = supervisor.Horario;
            String salario = supervisor.Salario;
            String areaSupervisada = supervisor.AreaSupervisada;
            MessageBox.Show("Datos del supervisor" + "\n" + "Apellidos:" + apellidos + "\n" + "Nombres:" + nombres + "\n" +
                "Celular:" + celular + "\n" + "DNI:" + dni + "\n" + "Correo:" + correo + "\n" + "Horario:" +
                horario + "\n" + "Salario:" + salario + "\n" + "Área supervisada:" + areaSupervisada);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Supervisar());
        }
        private void btnInformar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Informar());
        }
        private void btnControlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Controlar());
        }
        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supervisor.Autorizar());
        }
    }
}
