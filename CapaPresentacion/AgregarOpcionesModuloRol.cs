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

namespace CapaPresentacion
{
    public partial class AgregarOpcionesModuloRol : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        Boolean isInsert = true;
        int id_Opmodular = 0;
        public AgregarOpcionesModuloRol()
        {
            InitializeComponent();
        }

        private void BtnGuardarOpModuloRol_Click(object sender, EventArgs e)
        {

            try
            {
                if (isInsert)
                {
                    objCapaNegocio.InsertarOpMoRol(TxtIdOpModuloRol.Text, TxtIdOpModulo.Text, TxtIdRol.Text,CmbEstadoOpMoRol.Text); 
                    MessageBox.Show("Registro Insertado");
                    TxtIdOpModuloRol.Text = "";
                    TxtIdOpModulo.Text = "";
                    TxtIdRol.Text = "";
                    CmbEstadoOpMoRol.Text = "";
                   
                }
                else
                {
                    //    objCapaNegocio.ActualizarAlumno(TxtCedula.ToString(), TxtNombre.Text, TxtApellido.Text, TxtGenero.Text, TxtFecha.Text, TxtDireccion.Text, TxtTelefono.Text, TxtEstado.Text);
                    //    MessageBox.Show("Registro Actualizado");
                    isInsert = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void BtnSalirOpModuloRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
