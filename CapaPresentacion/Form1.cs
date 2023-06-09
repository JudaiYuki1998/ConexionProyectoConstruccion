using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {   
        CN_GetData objectCN = new CN_GetData();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            {
                if (objectCN.conSql(TxtUsuario.Text, TxtContrasena.Text) == 1)
                {


                    Form IniciarSecion = new Formulariomenuopciones();
                   
                    IniciarSecion.Show();
                    this.Hide();
                    
                   

                }
                else
                {

                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");



                }
                
            }

        }

        private void BtnIntegrantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CREADO POR(JHON JIMENEZ ,JOSE REYES, JORGE REYES, MELANYE LAINEZ, LADY PINCAY)");


        }
    }
}
