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
    public partial class Modulos : Form
    {
        Boolean isInsert = true;

        CN_GetData objectCN = new CN_GetData ();
        public Modulos()
        {
            InitializeComponent();
            comboBoxEstadoModulo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnSalirmodulosss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvModulos.SelectedRows.Count > 0)
            {
                //Pongo en mis cajas de Texto lo que haya seleccionado en la fila del DGV
                int indice = DgvModulos.CurrentCell.RowIndex;
                TextBoxIDModulo.Text = DgvModulos.Rows[indice].Cells[0].Value.ToString();
                TextBoxModulo.Text = DgvModulos.Rows[indice].Cells[1].Value.ToString();
                TextBoxObjeto.Text = DgvModulos.Rows[indice].Cells[2].Value.ToString();
                comboBoxEstadoModulo.Text = DgvModulos.Rows[indice].Cells[3].Value.ToString();

                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
  

        }



        private void Modulos_Load(object sender, EventArgs e)
        {
            DgvModulos.DataSource = objectCN.CN_GetModulos();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;// sal del metodo 
            }


            try
            {
                if (isInsert)
                {
                    objectCN.InsertarModulos(TextBoxIDModulo.Text, Convert.ToString(TextBoxModulo.Text), Convert.ToString(TextBoxObjeto.Text), comboBoxEstadoModulo.Text); ;
                    MessageBox.Show("Registro insertado");
                    // limpiar las cajas de texto
                    TextBoxModulo.Text = "";
                    TextBoxIDModulo.Text = "";
                    TextBoxObjeto.Text = "";
                  //  comboBoxEstadoModulo.Items.Clear();
                }
                else
                {
                    objectCN.ActualizarModulo(TextBoxIDModulo.Text.ToString(), TextBoxModulo.Text.ToString(), TextBoxObjeto.Text.ToString(), comboBoxEstadoModulo.Text.ToString());
                    MessageBox.Show("Registro Actualizado");
                    isInsert = true;
                    // limpiar las cajas de texto
                    TextBoxModulo.Text = "";
                    TextBoxIDModulo.Text = "";
                    TextBoxObjeto.Text = "";
                   // comboBoxEstadoModulo.Items.Clear();
                }

            }
            catch (Exception )
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FILA PARA EDITAR");
            }
            CargarModulo();
        }

        private void CargarModulo()
        {
            DgvModulos.DataSource = objectCN.CN_GetModulos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {


            //validar que haya filas seleccionadas
            if (DgvModulos.SelectedRows.Count > 0)
            {
                //pongo en mis cajas de texto lo que haya seleccionado en la fila del datagrivview
                int indice = DgvModulos.CurrentCell.RowIndex;
                int id_modulo = int.Parse(DgvModulos.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    //hacemos el llamado al metodo eliminar de la capa de negocio
                    objectCN.EliminarModulo(id_modulo.ToString());
                    MessageBox.Show("Registro Eliminado");

                }
                catch (Exception )
                {
                    MessageBox.Show("MODULO NO PUEDE SER ELIMINADO, ELIMINELO DE OPCIONES DE MODULO");
                }

            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
            CargarModulo();
        }


        bool validar()
        {
            bool valido = true;
            String mensaje = "";
            if (TextBoxIDModulo.Text.Equals("") || TextBoxModulo.Text.Equals("") || TextBoxObjeto.Text.Equals(""))
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



            if (comboBoxEstadoModulo.SelectedItem == null)
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

        private void TextBoxIDModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && TextBoxIDModulo.Text.Length < 10)
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

        private void TextBoxModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && TextBoxModulo.Text.Length <= 30)
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

        private void TextBoxObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) && TextBoxObjeto.Text.Length <= 30)
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
