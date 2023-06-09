using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Formulariomenuopciones : Form
    {
        public Formulariomenuopciones()
        {
            InitializeComponent();
        }

        private void mODULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form moduloss = new Modulos();
            moduloss.ShowDialog();
            
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form roless = new Roles();
            roless.ShowDialog();
        }

        private void mODULOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form aggmodulos = new GuardarModulos();
            aggmodulos.ShowDialog();
        }

        private void rOLESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form aggRoles = new GuardarRoles();
            aggRoles.ShowDialog();
        }

        private void BtnSalirMenu_Click(object sender, EventArgs e)
        {

            Form SalirAlLogin = new FormLogin();
            SalirAlLogin.Show();
            this.Hide();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SISTEMA DE INGRESO DE DATOS DE LA EMPRESA DE LICORES SAMBO","AYUDA",MessageBoxButtons.OK, MessageBoxIcon.Question);
            
            
        }

        private void uSUARIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void oPCIONESDEMODULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cREAROPCIONESMODULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aggOpModulos = new AgregarOpModulo();
            aggOpModulos.ShowDialog();
        }

        private void vIZUALIZAROPCIONESDEMODULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form verOpModulos = new Opmodulosver();
            verOpModulos.ShowDialog();
        }

        private void cREAROPCIONESMODULOPORROLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CrearOpModulosRol = new AgregarOpcionesModuloRol();
            CrearOpModulosRol.ShowDialog();
        }

        private void vISUALIZAROPCIONESMODULOPORROLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form verOpModulosRol = new OpcioModuloRol();
            verOpModulosRol.ShowDialog();

        }

        private void cREARPRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form aggproductos = new CrearProducto();
            aggproductos.ShowDialog();
        }

        private void Formulariomenuopciones_Load(object sender, EventArgs e)
        {

        }

        private void cREARVENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aggUsuarios = new GuardarUsuarios();
            aggUsuarios.ShowDialog();
        }

        private void mODIFICARVENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form usuarioss = new Usuarios();
            usuarioss.ShowDialog();
        }

        private void aSIGNACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vENDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VenderLicor = new VentaLicores();
            VenderLicor.ShowDialog();
        }

        private void vENDERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form VentaProductosLicores = new VentaLicores();
            VentaProductosLicores.ShowDialog();
        }
    }
}
