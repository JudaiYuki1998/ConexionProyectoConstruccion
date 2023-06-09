using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_GetData
    {

        private CD_Connection db_coneccion = new CD_Connection();

        SqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        SqlCommand sqlCommand = new SqlCommand();



        public DataTable GetData(string sql_text)
        {
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter;

            //Asignar la conexion
            sqlCommand.Connection = db_coneccion.OpenConnection();
            // El tipo de comando y asignado el sql 
            sqlCommand.CommandText = sql_text;
            //Llamamos al constructor del data adapter
            dataAdapter = new SqlDataAdapter(sqlCommand);
            //Asigno el dataAdapter al datatable
            dataAdapter.Fill(dataTable);
            //cerramos la conexión
            db_coneccion.CloseConnection();

            return dataTable;


        }

        public void InsertarModulos(string p_id,string p_nommodulo, string p_nomObjeto,string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "insertarModulos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMod", p_id);
            comando.Parameters.AddWithValue("@nomMod", p_nommodulo);
            comando.Parameters.AddWithValue("@nomObjeto", p_nomObjeto);
            comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void EliminarModulo(int p_id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            //definimos el nombre del procedimiento almacenado
            comando.CommandText = "EliminarModulo";
            //definimos que vamos a ejecutar  un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            //asignarle los parametros
            comando.Parameters.AddWithValue("@id_mod", p_id);
            //ejecutar el procedimiento
            comando.ExecuteNonQuery();
            //cierro la coneccion
            db_coneccion.CloseConnection();
        }

        public void ActualizarModulo(int id_mod, string nombre_modulo, string nombre_objeto, char estado)
        {
            //@id_mod int, @nombre_modulo varchar(80), @nombre_objeto numeric(8,0),@estado char
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            // definimos el nombre del procedimiento almacenado
            comando.CommandText = "ModificarModulo";
            // definimos que vamos a ejecutar un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            // Asignarle los parametros
            comando.Parameters.AddWithValue("@id_mod ", id_mod);
            comando.Parameters.AddWithValue("@nombre_modulo", nombre_modulo);
            comando.Parameters.AddWithValue("@nombre_objeto", nombre_objeto);
            comando.Parameters.AddWithValue("@estado", estado);
            // Ejecutar el procedimoiento
            comando.ExecuteNonQuery();
            // cierro la conexion
            db_coneccion.CloseConnection();

        }



        public void InsertarOpModulos(string p_idOpMod, string p_nomOp, string p_nomObjeto, string p_id,  string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "insertarOpModulos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idOpMod", p_idOpMod);
            comando.Parameters.AddWithValue("@nomOp", p_nomOp);
            comando.Parameters.AddWithValue("@nomObjeto", p_nomObjeto);
            comando.Parameters.AddWithValue("@idMod", p_id);
            comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void ModificarOpModulos(string p_idOpMod, string p_nomOp, string p_nomObjeto, string p_id, string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "ModificarOPModulos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idOpMod", p_idOpMod);
            comando.Parameters.AddWithValue("@nomOp", p_nomOp);
            comando.Parameters.AddWithValue("@nomObjeto", p_nomObjeto);
            comando.Parameters.AddWithValue("@idMod", p_id);
            comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void EliminarOpModulos(int p_idOpMod)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            //definimos el nombre del procedimiento almacenado
            comando.CommandText = "EliminarOpModulos";
            //definimos que vamos a ejecutar  un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            //asignarle los parametros
            comando.Parameters.AddWithValue("@idOpMod", p_idOpMod);
            //ejecutar el procedimiento
            comando.ExecuteNonQuery();
            //cierro la coneccion
            db_coneccion.CloseConnection();
        }

        public void InsertarOpMoRol(string p_idOpMorol,string p_idOpMod,string id_rol, string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "insertarOpMoRol";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idOpMoRol", p_idOpMorol);
            comando.Parameters.AddWithValue("@idOpMod", p_idOpMod);
            comando.Parameters.AddWithValue("@idRol", id_rol);
           comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void ModificarOpMoRol(string p_idOpMorol, string p_idOpMod, string id_rol, string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "ModificarOpMoRol";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idOpMoRol", p_idOpMorol);
            comando.Parameters.AddWithValue("@idOpMod", p_idOpMod);
            comando.Parameters.AddWithValue("@idRol", id_rol);
            comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void EliminarOpMoRol(int id_rol)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "EliminarOpMoRol";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idOpMoRol", id_rol);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }






        public void InsertarRoles(string p_idrol, string p_nomrol, string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "insertarRoles";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idRol", p_idrol);
            comando.Parameters.AddWithValue("@nomRol", p_nomrol);
            comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void EliminarRol(int p_idrol)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            //definimos el nombre del procedimiento almacenado
            comando.CommandText = "EliminarRol";
            //definimos que vamos a ejecutar  un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            //asignarle los parametros
            comando.Parameters.AddWithValue("@id_rol", p_idrol);
            //ejecutar el procedimiento
            comando.ExecuteNonQuery();
            //cierro la coneccion
            db_coneccion.CloseConnection();
        }

        public void ActualizarRol(int id_rol, string nombre_rol, char estado)
        {
            //@id_rol int, @nombre_rol varchar(80),@estado_rol char
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            // definimos el nombre del procedimiento almacenado
            comando.CommandText = "ModificarRol";
            // definimos que vamos a ejecutar un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            // Asignarle los parametros
            comando.Parameters.AddWithValue("@id_rol", id_rol);
            comando.Parameters.AddWithValue("@nombre_rol", nombre_rol);
            comando.Parameters.AddWithValue("@estado_rol", estado);
            // Ejecutar el procedimoiento
            comando.ExecuteNonQuery();
            // cierro la conexion
            db_coneccion.CloseConnection();

        }

        public void InsertarUsuarios(string p_idUser,string p_UserName, string p_pasclave, string p_idrol, string p_NombreUsuario, string p_Telefono, string p_Direccion, string p_Mail, string p_estado)

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            comando.CommandText = "insertarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUser", p_idUser);
            comando.Parameters.AddWithValue("@nomUsername", p_UserName);
            comando.Parameters.AddWithValue("@pas_clave", p_pasclave);
            comando.Parameters.AddWithValue("@idRol", p_idrol);
            comando.Parameters.AddWithValue("@nomUsuario", p_NombreUsuario);
            comando.Parameters.AddWithValue("@p_Telefono", p_Telefono);
            comando.Parameters.AddWithValue("@p_Direccion", p_Direccion);
            comando.Parameters.AddWithValue("@p_Mail", p_Mail);
            comando.Parameters.AddWithValue("@stado", p_estado);

            comando.ExecuteNonQuery();

            db_coneccion.CloseConnection();

        }

        public void ModificarUsuario(string p_idUser, string p_UserName, string p_pasclave, string p_idrol, string p_NombreUsuario, string p_Telefono, string p_Direccion, string p_Mail, string p_estado)
        {
            //@id_rol int, @nombre_rol varchar(80),@estado_rol char
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            // definimos el nombre del procedimiento almacenado
            comando.CommandText = "ModificarUsuario";
            // definimos que vamos a ejecutar un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            // Asignarle los parametros
            comando.Parameters.AddWithValue("@idUser", p_idUser);
            comando.Parameters.AddWithValue("@nomUsername", p_UserName);
            comando.Parameters.AddWithValue("@pas_clave", p_pasclave);
            comando.Parameters.AddWithValue("@idRol", p_idrol);
            comando.Parameters.AddWithValue("@nomUsuario", p_NombreUsuario);
            comando.Parameters.AddWithValue("@p_Telefono", p_Telefono);
            comando.Parameters.AddWithValue("@p_Direccion", p_Direccion);
            comando.Parameters.AddWithValue("@p_Mail", p_Mail);
            comando.Parameters.AddWithValue("@stado", p_estado);

            // Ejecutar el procedimoiento
            comando.ExecuteNonQuery();
            // cierro la conexion
            db_coneccion.CloseConnection();

        }
        public void EliminarUsuario(int p_idUser)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = db_coneccion.OpenConnection();
            //definimos el nombre del procedimiento almacenado
            comando.CommandText = "EliminarUsuario";
            //definimos que vamos a ejecutar  un store procedure
            comando.CommandType = CommandType.StoredProcedure;
            //asignarle los parametros
            comando.Parameters.AddWithValue("@idUser", p_idUser);
            //ejecutar el procedimiento
            comando.ExecuteNonQuery();
            //cierro la coneccion
            db_coneccion.CloseConnection();
        }

    }
}
