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
    public partial class FrmEnsamblador : Form
    {
        public FrmEnsamblador()
        {
            InitializeComponent();
        }
        Ensamblador ensamblador = new Ensamblador();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string dni = txtDni.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string componentesUsados = txtComponentesUsados.Text.Trim();
            //Escribir los datos de alumno
            ensamblador.Apellidos = apellidos;
            ensamblador.Nombres = nombres;
            ensamblador.Celular = celular;
            ensamblador.Dni = dni;
            ensamblador.Correo = correo;
            ensamblador.Horario = horario;
            ensamblador.ComponentesUsados = componentesUsados;
            //Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //limpiar cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtHorario.Clear();
            txtComponentesUsados.Clear();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = ensamblador.Apellidos;
            string nombres = ensamblador.Nombres;
            string celular = ensamblador.Celular;
            string dni = ensamblador.Dni;
            string correo = ensamblador.Correo;
            string horario = ensamblador.Horario;
            string componentesUsados = ensamblador.ComponentesUsados;
            MessageBox.Show("Datos del Ensamblador" + "\n" + "Apellidos:" + apellidos + "\n" + "Nombres:" + nombres + "\n" +
             "Celular:" + celular + "\n" + "DNI:" + dni + "\n" + "Correo:" + correo + "\n" + "Horario:" + horario + "\n" + "Componentes Usados:" + componentesUsados);
        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Ensamblar());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Ordenar());
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ensamblador.Contar());
        }
    }
}
