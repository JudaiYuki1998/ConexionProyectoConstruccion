using CapaNegocio;
using System;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class GuardarUsuarios : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocio.CN_GetData();
        Boolean isInsert = true;
        int id_Usuariosss = 0;

        public GuardarUsuarios()
        {
            InitializeComponent();
            CmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarUsuario_Click(object sender, EventArgs e)
        {

          
            if (!validar())
            {
                return;// sal del metodo 
            }

            try
            {
                if (isInsert)
                {
                    
                    objCapaNegocio.InsertarUsuarios(TxtIdUsuario.Text,Convert.ToString(TxtUsuario.Text), Convert.ToString(TxtClave.Text), TxtIdRol.Text, Convert.ToString(TxtNombreUsuario.Text), Convert.ToString(Txttelefono.Text), Convert.ToString(TxtDireccion.Text), Convert.ToString(TxtMail.Text), CmbEstado.Text); ;
                    MessageBox.Show("Registro Insertado");
                    // limpiar las cajas de texto
                    TxtIdUsuario.Text = "";
                    TxtUsuario.Text = "";
                    TxtClave.Text = "";
                    TxtIdRol.Text = "";
                    TxtNombreUsuario.Text = "";
                    Txttelefono.Text = "";
                    TxtDireccion.Text = "";
                    TxtMail.Text = "";
                    CmbEstado.Items.Clear();
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
                MessageBox.Show("ID USUARIO EXISTENTE INGRESE OTRO ");
            }



        }

        public void GuardarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void CmbIdRol_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        bool validar()
        {
            //TxtIdUsuario.Text, TxtUsuario.Text, TxtClave.Text, TxtIdRol.Text, TxtNombreUsuario.Text, Txttelefono.Text, TxtDireccion.Text,TxtMail.Text, CmbEstado.Text
            bool valido = true;
            String mensaje = "";
            if (TxtIdUsuario.Text.Equals("") || TxtUsuario.Text.Equals("") || TxtNombreUsuario.Text.Equals("") || Txttelefono.Text.Equals("") || TxtDireccion.Text.Equals("") || TxtMail.Text.Equals(""))
            {
                valido = false;
                mensaje+= " no se permiten campos vacios\n ";
            }


          //  if (TxtMail.Text.LastIndexOf("@ug.edu.ec") < 0)
            ///    {
           //     MessageBox.Show("Debe cumplir con el formato requerido @ug.edu.ec ");
          //  }

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



            if (CmbEstado.SelectedItem == null)
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

        private void TxtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && TxtIdUsuario.Text.Length < 10)
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

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (TxtMail.Text.LastIndexOf("@ug.edu.ec") < 0)
            //{
            //MessageBox.Show("Debe cumplir con el formato requerido ejemplo@ug.edu.ec ");
            //}
            if (char.IsLetterOrDigit(e.KeyChar) && TxtUsuario.Text.Length <= 50)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("no se permite carateres especiales excepto un arroba , guion o subguion y un punto");
                e.Handled = true;
            }

        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && (TxtClave.Text.Length <= 10))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("no se permite caracteres especiales , ni espacios y la longitud de la clave solo es hasta 10  ");
                e.Handled = true;
            }


        }

        private void TxtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && TxtNombreUsuario.Text.Length <= 30)
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

        private void Txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && Txttelefono.Text.Length < 10)
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

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && TxtDireccion.Text.Length <= 50)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("no se permite caracteres especiales");
                e.Handled = true;
            }

        }

        private void TxtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (TxtMail.Text.LastIndexOf("@ug.edu.ec") < 0)
            //{
            //MessageBox.Show("Debe cumplir con el formato requerido ejemplo@ug.edu.ec ");
            //}
            if (char.IsLetterOrDigit(e.KeyChar) && TxtDireccion.Text.Length <= 50)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("no se permite carateres especiales excepto un arroba , guion o subguion y un punto");
                e.Handled = true;
            }

        }
    }
}
