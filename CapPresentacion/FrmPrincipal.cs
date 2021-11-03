using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCPU frmCpu = new FrmCPU();
            frmCpu.Show();
        }

        private void compradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComprador frmComprador = new FrmComprador();
            frmComprador.Show();
        }

        private void accesorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccesorio frmAccesorio = new FrmAccesorio();
            frmAccesorio.Show();
        }

        private void ensambladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnsamblador frmEnsamblador = new FrmEnsamblador();
            frmEnsamblador.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupervisor frmSupervisor = new FrmSupervisor();
            frmSupervisor.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedor frmVendedor = new FrmVendedor();
            frmVendedor.Show();
        }

        private void distribuidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistribuidor frmDistribuidor = new FrmDistribuidor();
            frmDistribuidor.Show();
        }

        private void monitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonitor frmMonitor = new FrmMonitor();
            frmMonitor.Show();
        }

    }
}
