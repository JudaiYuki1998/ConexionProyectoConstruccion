using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
     public class CN_GetData
    {
        private CD_GetData objectCD = new CD_GetData();
        //
        CD_Connection cn = new CD_Connection();

        public int conSql(string user, string pass)
        {

            return cn.consultaLogin(user, pass);



        }


        //

        private DataTable CN_ShowData(string sql_text)
        {

            DataTable mytable = new DataTable();
            mytable = objectCD.GetData(sql_text);
            return mytable;

        }
        public DataTable CN_GetModulos()
        {
            String sql_text = "select * from TB_SEGU_MODULOS";
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData(sql_text);
            return dataRetorno;

        }
        public DataTable CN_GetOpModulos()
        {
            String sql_text = "select * from TB_SEGU_OPCIONES_MODULOS";
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData(sql_text);
            return dataRetorno;

        }
        public DataTable CN_GetOpModulosRol()
        {
            String sql_text = "select * from TB_SEGU_OPCIONES_MODULO_X_ROL";
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData(sql_text);
            return dataRetorno;

        }


        public DataTable CN_GetRoles()
        {
            String sql_text = "select * from TB_SEGU_ROL";
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData(sql_text);
            return dataRetorno;

        }


        public DataTable CN_GetUsuarios()
        {
            String sql_text = "select * from TB_SEGU_USER";
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData(sql_text);
            return dataRetorno;

        }


        public void InsertarModulos(string p_id,string p_nommodulo, string p_nomObjeto,string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.InsertarModulos(p_id,p_nommodulo, p_nomObjeto,p_estado);


            }


        }

        public void ActualizarModulo(string id_mod, string nombre_modulo, string nombre_objeto, string estado)
        {
            // Llamamos al metodo de la capa de Datos
            objectCD.ActualizarModulo(int.Parse(id_mod), nombre_modulo, nombre_objeto, char.Parse(estado));

        }


        public void EliminarModulo(string id_mod)
        {
            //lamamos al onjeto de la capa de datos
            objectCD.EliminarModulo(int.Parse(id_mod));
        }


        public void InsertarOpModulos(string p_idOpMod, string p_nomOp, string p_nomObjeto, string p_id, string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.InsertarOpModulos(p_idOpMod,p_nomOp, p_nomObjeto,p_id, p_estado);


            }


        }

        public void ModificarOpModulos(string p_idOpMod, string p_nomOp, string p_nomObjeto, string p_id, string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.ModificarOpModulos(p_idOpMod, p_nomOp, p_nomObjeto, p_id, p_estado);


            }


        }

        public void EliminarOpModulos(string p_idOpMod)
        {
            //lamamos al onjeto de la capa de datos
            objectCD.EliminarOpModulos(int.Parse(p_idOpMod));
        }

        public void InsertarOpMoRol(string p_idOpMorol, string p_idOpMod, string id_rol, string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.InsertarOpMoRol(p_idOpMorol,p_idOpMod, id_rol, p_estado);


            }


        }
        public void EliminarOpMoRol(string p_idOpMorol)
        {
            //lamamos al onjeto de la capa de datos
            objectCD.EliminarOpMoRol(int.Parse(p_idOpMorol));
        }

        public void ModificarOpMoRol(string p_idOpMorol, string p_idOpMod, string id_rol, string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.ModificarOpMoRol(p_idOpMorol, p_idOpMod, id_rol, p_estado);


            }


        }

        public void InsertarRoles(string p_idrol, string p_nomrol, string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.InsertarRoles(p_idrol, p_nomrol, p_estado);


            }


        }

        public void ActualizarRol(string id_rol, string nombre_rol, string estado)
        {
            // Llamamos al metodo de la capa de Datos
            objectCD.ActualizarRol(int.Parse(id_rol), nombre_rol, char.Parse(estado));

        }

        public void EliminarRol(string p_idrol)
        {
            //lamamos al onjeto de la capa de datos
            objectCD.EliminarRol(int.Parse(p_idrol));
        }

        public void InsertarUsuarios(string p_idUser,string p_UserName, string p_pasclave, string p_idrol, string p_NombreUsuario, string p_Telefono, string p_Direccion, string p_Mail, string p_estado)
        {

            {
                // Llamamos al metodo de la capa de Datos
                objectCD.InsertarUsuarios(p_idUser, p_UserName, p_pasclave, p_idrol,p_NombreUsuario,p_Telefono,p_Direccion,p_Mail, p_estado);


            }


        }

        public void ModificarUsuario(string p_idUser, string p_UserName, string p_pasclave, string p_idrol, string p_NombreUsuario, string p_Telefono, string p_Direccion, string p_Mail, string p_estado)
        {
            // Llamamos al metodo de la capa de Datos
            objectCD.ModificarUsuario(p_idUser, p_UserName, p_pasclave, p_idrol, p_NombreUsuario, p_Telefono, p_Direccion, p_Mail, p_estado);

        }

        public void EliminarUsuario(string p_idUser)
        {
            //lamamos al onjeto de la capa de datos
            objectCD.EliminarUsuario(int.Parse(p_idUser));
        }


    }
}
