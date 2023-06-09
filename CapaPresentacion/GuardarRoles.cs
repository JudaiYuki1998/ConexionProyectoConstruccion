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
    public partial class GuardarRoles : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        Boolean isInsert = true;
        int id_Rolessss = 0;
        public GuardarRoles()
        {
            InitializeComponent();
            CmbEstadoRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnGuardarRol_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;// sal del metodo 
            }

            try
            {
                if (isInsert)
                {
                    objCapaNegocio.InsertarRoles(TxtIdRol.Text, Convert.ToString (TxtNombreRol.Text),CmbEstadoRoles.Text); ;
                    MessageBox.Show("Registro Insertado");
                    // limpiar las cajas de texto
                    TxtIdRol.Text = "";
                    TxtNombreRol.Text = "";
                    CmbEstadoRoles.Items.Clear();
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
                MessageBox.Show("ID DE ROL DE EXISTE , INGRESE OTRO");
            }



        }

        private void BtnSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void TxtIdRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && TxtIdRol.Text.Length < 10)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("Sólo se permiten numeros, hasta 10 y sin espacios");
                e.Handled = true;
            }

        }

        private void TxtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && TxtNombreRol.Text.Length <= 30)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Sólo se permiten letras, hasta 30");
                e.Handled = true;
            }

        }





        bool validar()
        {
            bool valido = true;
            String mensaje = "";
            if (TxtIdRol.Text.Equals("") || TxtNombreRol.Text.Equals("") )
            {
                valido = false;
                mensaje += " no se permiten campos vacios\n ";
            }

            //if (TxtIdModulo.Text.Length < 10)
            //{
            // valido = false;
            //mensaje += "\nLongitud minima id es 10";
            //}

            //if (textBoxTitulo.Text.LastIndexOf("@ug.edu.ec") < 0)
            //{

            //}
            //if (TxtModulo.Text.Length < 15 || TxtObjeto.Text.Length < 15)
            //{
            // valido = false;
            //mensaje += "\nLongitud minima de modulo es 15 y de objeto es 15";
            //}



            if (CmbEstadoRoles.SelectedItem == null)
            {
                valido = false;
                mensaje += "\n y tambien se debe seleccionar A(activo) o I(Inactivo)";
            }



            if (!valido)
            {
                MessageBox.Show(mensaje, "Advertencia");
            }
            return valido;
        }
    }
}
