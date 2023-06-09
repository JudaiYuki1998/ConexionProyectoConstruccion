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
    public partial class OpcioModuloRol : Form
    {
        CN_GetData objectCN = new CN_GetData();
        Boolean isInsert = true;
        public OpcioModuloRol()
        {
            InitializeComponent();
        }

        private void BtnSalirRolessss_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpcioModuloRol_Load(object sender, EventArgs e)
        {
            DgvOpMoRol.DataSource = objectCN.CN_GetOpModulosRol();
        }

        private void CargarModuloRol()
        {
            DgvOpMoRol.DataSource = objectCN.CN_GetOpModulosRol();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditarRoles_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (isInsert)
                    {
                        objectCN.InsertarOpMoRol(TxtOpMoRol.Text, TxtIdOpMoRol.Text, TxtIdRol.Text, CmbEstado.Text); ;
                        MessageBox.Show("Registro insertado");
                        TxtOpMoRol.Text = "";
                        TxtIdOpMoRol.Text = "";
                        TxtIdRol.Text = "";

                    }
                    else
                    {
                        objectCN.ModificarOpMoRol(TxtOpMoRol.Text.ToString(), TxtIdOpMoRol.Text.ToString(), TxtIdRol.Text.ToString(), CmbEstado.Text.ToString());
                        MessageBox.Show("Registro Actualizado");
                        TxtOpMoRol.Text = "";
                        TxtIdOpMoRol.Text = "";
                        TxtIdRol.Text = "";
                        isInsert = true;
                    }

                }
                catch (Exception )
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA FILA PARA EDITAR");
                }
                CargarModuloRol();
            }

        }

        private void DgvOpMoRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (DgvOpMoRol.SelectedRows.Count > 0)
                {
                    //Pongo en mis cajas de Texto lo que haya seleccionado en la fila del DGV
                    int indice = DgvOpMoRol.CurrentCell.RowIndex;
                    TxtOpMoRol.Text = DgvOpMoRol.Rows[indice].Cells[0].Value.ToString();
                    TxtIdOpMoRol.Text = DgvOpMoRol.Rows[indice].Cells[1].Value.ToString();
                    TxtIdRol.Text = DgvOpMoRol.Rows[indice].Cells[2].Value.ToString();
                    CmbEstado.Text = DgvOpMoRol.Rows[indice].Cells[3].Value.ToString();


                    isInsert = false;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }


            }
        }

        private void buttonEliminarRol_Click(object sender, EventArgs e)
        {
            //validar que haya filas seleccionadas
            if (DgvOpMoRol.SelectedRows.Count > 0)
            {
                //pongo en mis cajas de texto lo que haya seleccionado en la fila del datagrivview
                int indice = DgvOpMoRol.CurrentCell.RowIndex;
                int p_idOpMorol = int.Parse(DgvOpMoRol.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    //hacemos el llamado al metodo eliminar de la capa de negocio
                    objectCN.EliminarOpMoRol(p_idOpMorol.ToString());
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
            CargarModuloRol();
        }
    }
}
