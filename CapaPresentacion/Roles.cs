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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Roles : Form
    {

        CN_GetData objectCN = new CN_GetData();
        Boolean isInsert = true;
        public Roles()
        {
            InitializeComponent();
        }

        private void BtnSalirRolessss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            DgvRoles.DataSource = objectCN.CN_GetRoles();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CargarRol()
        {
            DgvRoles.DataSource = objectCN.CN_GetRoles();
        }
        private void buttonEditarRoles_Click(object sender, EventArgs e)
        {
            //
            if (!validar())
            {
                return;// sal del metodo 
            }

            try
                {
                    if (isInsert)
                    {
                        objectCN.InsertarRoles(TextBoxIdRol.Text, Convert.ToString(TextBoxRol.Text), comboBoxEstadoRoles.Text); ;
                        MessageBox.Show("Registro insertado");
                    TextBoxIdRol.Text = "";
                    TextBoxRol.Text = "";
                   // comboBoxEstadoRoles.Items.Clear();

                }
                    else
                    {
                        objectCN.ActualizarRol(TextBoxIdRol.Text.ToString(), TextBoxRol.Text.ToString(), comboBoxEstadoRoles.Text.ToString());
                        MessageBox.Show("Registro Actualizado");
                        isInsert = true;
                    TextBoxIdRol.Text = "";
                    TextBoxRol.Text = "";
                   // comboBoxEstadoRoles.Items.Clear();
                }

                }
                catch (Exception )
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA FILA PARA EDITAR");
                }
                CargarRol();
            

        }

        private void buttonEliminarRol_Click(object sender, EventArgs e)
        {
            //validar que haya filas seleccionadas
            if (DgvRoles.SelectedRows.Count > 0)
            {
                //pongo en mis cajas de texto lo que haya seleccionado en la fila del datagrivview
                int indice = DgvRoles.CurrentCell.RowIndex;
                int p_idrol = int.Parse(DgvRoles.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    //hacemos el llamado al metodo eliminar de la capa de negocio
                    objectCN.EliminarRol(p_idrol.ToString());
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
            CargarRol();
        }

        private void DgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (DgvRoles.SelectedRows.Count > 0)
                {
                    //Pongo en mis cajas de Texto lo que haya seleccionado en la fila del DGV
                    int indice = DgvRoles.CurrentCell.RowIndex;
                    TextBoxIdRol.Text = DgvRoles.Rows[indice].Cells[0].Value.ToString();
                    TextBoxRol.Text = DgvRoles.Rows[indice].Cells[1].Value.ToString();
                    comboBoxEstadoRoles.Text = DgvRoles.Rows[indice].Cells[2].Value.ToString();


                    isInsert = false;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            

            }
        }

        private void DgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool validar()
        {
            bool valido = true;
            String mensaje = "";
            if (TextBoxIdRol.Text.Equals("") || TextBoxRol.Text.Equals(""))
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



            if (comboBoxEstadoRoles.SelectedItem == null)
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

        private void TextBoxIdRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && TextBoxIdRol.Text.Length < 10)
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

        private void TextBoxRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && TextBoxRol.Text.Length <= 30)
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
