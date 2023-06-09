using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        CN_GetData objectCN = new CN_GetData();
        Boolean isInsert = true;
        public Usuarios()
        {
            InitializeComponent();
            CmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnSalirUsuariosssss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = objectCN.CN_GetUsuarios();
        }
        private void CargarUsuarios()
        {
            DgvUsuarios.DataSource = objectCN.CN_GetUsuarios();
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (DgvUsuarios.SelectedRows.Count > 0)
                {
                    //Pongo en mis cajas de Texto lo que haya seleccionado en la fila del DGV
                    int indice = DgvUsuarios.CurrentCell.RowIndex;
                    TxtIdUsuario.Text = DgvUsuarios.Rows[indice].Cells[0].Value.ToString();
                    TxtUsuario.Text = DgvUsuarios.Rows[indice].Cells[1].Value.ToString();
                    TxtClave.Text = DgvUsuarios.Rows[indice].Cells[2].Value.ToString();
                    TxtIdRol.Text = DgvUsuarios.Rows[indice].Cells[3].Value.ToString();
                    TxtNombreUsuario.Text = DgvUsuarios.Rows[indice].Cells[4].Value.ToString();
                    Txttelefono.Text = DgvUsuarios.Rows[indice].Cells[5].Value.ToString();
                    TxtDireccion.Text = DgvUsuarios.Rows[indice].Cells[6].Value.ToString();
                    TxtMail.Text = DgvUsuarios.Rows[indice].Cells[7].Value.ToString();
                    CmbEstado.Text = DgvUsuarios.Rows[indice].Cells[8].Value.ToString();


                    isInsert = false;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }


            }
        }



        private void buttonEditarUsuarios_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;// sal del metodo 
            }


            try
                {
                    if (isInsert)
                    {
                        objectCN.InsertarUsuarios(TxtIdUsuario.Text, TxtUsuario.Text, TxtClave.Text, TxtIdRol.Text, TxtNombreUsuario.Text, Txttelefono.Text, TxtDireccion.Text, TxtMail.Text,CmbEstado.Text); ;
                        MessageBox.Show("Registro insertado");
                    // limpiar las cajas de texto
                    TxtIdUsuario.Text = "";
                    TxtUsuario.Text = "";
                    TxtClave.Text = "";
                    TxtNombreUsuario.Text = "";
                    Txttelefono.Text = "";
                    TxtDireccion.Text = "";
                    TxtMail.Text = "";
                 //   CmbEstado.Items.Clear();
                    
                }
                    else
                    {
                        objectCN.ModificarUsuario(TxtIdUsuario.Text.ToString(), TxtUsuario.Text.ToString(), TxtClave.Text.ToString(), TxtIdRol.Text.ToString(), TxtNombreUsuario.Text.ToString(), Txttelefono.Text.ToString(), TxtDireccion.Text.ToString(), TxtMail.Text.ToString(), CmbEstado.Text.ToString());
                        MessageBox.Show("Registro Actualizado");
                        isInsert = true;
                    // limpiar las cajas de texto
                    TxtIdUsuario.Text = "";
                    TxtUsuario.Text = "";
                    TxtClave.Text = "";
                    TxtNombreUsuario.Text = "";
                    Txttelefono.Text = "";
                    TxtDireccion.Text = "";
                    TxtMail.Text = "";
                    TxtIdRol.Text = "";
                   // CmbEstado.Items.Clear();
                }

                }
                catch (Exception )
                {
                    MessageBox.Show("ROL NO EXISTENTE AGREGUE UN ROL");
                }
                CargarUsuarios();
            

        }

        private void buttonEliminarUsuarios_Click(object sender, EventArgs e)
        {
            //validar que haya filas seleccionadas
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                //pongo en mis cajas de texto lo que haya seleccionado en la fila del datagrivview
                int indice = DgvUsuarios.CurrentCell.RowIndex;
                int p_idUser = int.Parse(DgvUsuarios.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    //hacemos el llamado al metodo eliminar de la capa de negocio
                    objectCN.EliminarUsuario(p_idUser.ToString());
                    MessageBox.Show("Registro Eliminado");

                }
                catch (Exception )
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA FILA PARA ELIMINAR");
                }

            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
            CargarUsuarios();
        }

        bool validar()
        {
            //TxtIdUsuario.Text, TxtUsuario.Text, TxtClave.Text, TxtIdRol.Text, TxtNombreUsuario.Text, Txttelefono.Text, TxtDireccion.Text,TxtMail.Text, CmbEstado.Text
            bool valido = true;
            String mensaje = "";
            if (TxtIdUsuario.Text.Equals("") || TxtUsuario.Text.Equals("") || TxtNombreUsuario.Text.Equals("") || Txttelefono.Text.Equals("") || TxtDireccion.Text.Equals("") || TxtMail.Text.Equals(""))
            {
                valido = false;
                mensaje += " no se permiten campos vacios\n ";
            }


          //  if (TxtMail.Text.LastIndexOf("@ug.edu.ec") < 0)
          //  {
           //     MessageBox.Show("Debe cumplir con el formato requerido @ug.edu.ec ");
           // }

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
            if (char.IsLetterOrDigit(e.KeyChar) && TxtMail.Text.Length <= 50)
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
