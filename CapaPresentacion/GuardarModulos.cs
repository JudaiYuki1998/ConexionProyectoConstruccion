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
    public partial class GuardarModulos : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        Boolean isInsert = true;
        int id_modular= 0;

        public GuardarModulos()
        {
            InitializeComponent();
            CmbEstadoModulos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GuardarModulos_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarModulo_Click(object sender, EventArgs e)
        {
            //
            if (!validar())
            {
                return ;// sal del metodo 
            }

            try
            {
                if (isInsert)
                {
                    objCapaNegocio.InsertarModulos(TxtIdModulo.Text, Convert.ToString(TxtModulo.Text), Convert.ToString(TxtObjeto.Text),CmbEstadoModulos.Text); ;
                    MessageBox.Show("Registro Insertado");
                    // limpiar las cajas de texto
                    TxtIdModulo.Text = "";
                    TxtModulo.Text = "";
                    TxtObjeto.Text = "";
                    CmbEstadoModulos.Items.Clear();
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
                MessageBox.Show("ID MODULO EXISTENTE ,INSERTE OTRO");
            }
           


        }


        private void BtnSalirModulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        bool validar()
        {
            bool valido = true;
            String mensaje = "";
            if (TxtIdModulo.Text.Equals("") || TxtModulo.Text.Equals("") ||TxtObjeto.Text.Equals(""))
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



            if (CmbEstadoModulos.SelectedItem == null)
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

        private void TxtIdModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && TxtIdModulo.Text.Length <10)
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

        private void TxtModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (char.IsLetter(e.KeyChar) && TxtModulo.Text.Length <= 30)
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

        private void TxtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (char.IsLetter(e.KeyChar) && TxtObjeto.Text.Length <= 30)
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
    }
}
