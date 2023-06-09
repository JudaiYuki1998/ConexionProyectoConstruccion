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
    public partial class Opmodulosver : Form
    {
        CN_GetData objectCN = new CN_GetData();
        Boolean isInsert = true;
        public Opmodulosver()
        {
            InitializeComponent();
        }

        private void BtnSalirOpModulos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarOpModulos()
        {
            DgvOpModulos.DataSource = objectCN.CN_GetOpModulos();
        }

        private void Opmodulosver_Load(object sender, EventArgs e)
        {
            DgvOpModulos.DataSource = objectCN.CN_GetOpModulos();
        }

        private void BtnModificarOpModulo_Click(object sender, EventArgs e)
        {


            try
            {
                if (isInsert)
                {
                    objectCN.InsertarOpModulos(TxtIpOpMo.Text, TxtNombreOp.Text, TxtNombreObjeto.Text, TxtIdModulo.Text,CmbEstado.Text);
                    MessageBox.Show("Registro insertado");
                    TxtIdModulo.Text = "";
                    TxtIpOpMo.Text = "";
                    TxtNombreObjeto.Text = "";
                    TxtNombreOp.Text = "";
                }
                else
                {
                    objectCN.ModificarOpModulos(TxtIpOpMo.Text.ToString(), TxtNombreOp.Text.ToString(), TxtNombreObjeto.Text.ToString(),TxtIdModulo.Text.ToString(), CmbEstado.Text.ToString());
                    MessageBox.Show("Registro Actualizado");
                    TxtIdModulo.Text = "";
                    TxtIpOpMo.Text = "";
                    TxtNombreObjeto.Text = "";
                    TxtNombreOp.Text = "";

                    isInsert = true;

                }

            }
            catch (Exception )
            {
                MessageBox.Show("ID DE MODULO NO EXISTE , INGRESE OTRO");
            }
            CargarOpModulos();
        }


        private void bTN_Click(object sender, EventArgs e)
        {
            //validar que haya filas seleccionadas
            if (DgvOpModulos.SelectedRows.Count > 0)
            {
                //pongo en mis cajas de texto lo que haya seleccionado en la fila del datagrivview
                int indice = DgvOpModulos.CurrentCell.RowIndex;
                int p_idOpMod = int.Parse(DgvOpModulos.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    //hacemos el llamado al metodo eliminar de la capa de negocio
                    objectCN.EliminarOpModulos(p_idOpMod.ToString());
                    MessageBox.Show("Registro Eliminado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
            CargarOpModulos();
        }


        private void DgvOpModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (DgvOpModulos.SelectedRows.Count > 0)
                {
                    //Pongo en mis cajas de Texto lo que haya seleccionado en la fila del DGV
                    int indice = DgvOpModulos.CurrentCell.RowIndex;
                    TxtIpOpMo.Text = DgvOpModulos.Rows[indice].Cells[0].Value.ToString();
                    TxtNombreOp.Text = DgvOpModulos.Rows[indice].Cells[1].Value.ToString();
                    TxtNombreObjeto.Text = DgvOpModulos.Rows[indice].Cells[2].Value.ToString();
                    TxtIdModulo.Text = DgvOpModulos.Rows[indice].Cells[3].Value.ToString();
                    CmbEstado.Text = DgvOpModulos.Rows[indice].Cells[4].Value.ToString();


                    isInsert = false;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }


            }
        }
    }
}
