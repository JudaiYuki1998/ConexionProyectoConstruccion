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
    public partial class AgregarOpModulo : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        Boolean isInsert = true;
        int id_Opmodular = 0;
        public AgregarOpModulo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarOpModulo_Click(object sender, EventArgs e)
        {

            try
            {
                if (isInsert)
                {
                    objCapaNegocio.InsertarOpModulos(TxtIdOpModulo.Text, TxtNombreOpcion.Text, TxtOpObjeto.Text, TxtIdModulo.Text, CmbEstadoOpmodulo.Text); ;
                    MessageBox.Show("Registro Insertado");
                    TxtIdOpModulo.Text = "";
                    TxtNombreOpcion.Text = "";
                    TxtOpObjeto.Text = "";
                    TxtIdModulo.Text = "";
                    CmbEstadoOpmodulo.Text = "";

                }
                else
                {
                    //    objCapaNegocio.ActualizarAlumno(TxtCedula.ToString(), TxtNombre.Text, TxtApellido.Text, TxtGenero.Text, TxtFecha.Text, TxtDireccion.Text, TxtTelefono.Text, TxtEstado.Text);
                    //    MessageBox.Show("Registro Actualizado");
                    isInsert = true;
                }

            }
            catch (Exception )
            {
                MessageBox.Show("ID OPCION DE MODULO EXISTENTE, INGRESE OTRO");
            }



        }

        private void BtnSalirOpModulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
