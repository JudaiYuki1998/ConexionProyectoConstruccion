using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Connection
    {
        private SqlConnection DB_Connection = new SqlConnection("Server=DESKTOP-BNFJ4P7;Database=POE_DB; Integrated Security=true");
        //
        static string conexionstring = "Server=DESKTOP-BNFJ4P7;Database=POE_DB; Integrated Security=true";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultaLogin(string Usuario, string Contrasena)
        {
            int count;
            DB_Connection.Open();
            string Query = "select Count(*) from TB_SEGU_USER where USERNAME= '" + Usuario + "'and CLAVE = '" + Contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, DB_Connection);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            DB_Connection.Close();
            return count;
        }


        //






        public SqlConnection OpenConnection()
        {

            if (DB_Connection.State == ConnectionState.Closed)
                DB_Connection.Open();

            return DB_Connection;

        }

        public SqlConnection CloseConnection()
        {

            if (DB_Connection.State == ConnectionState.Open)
                DB_Connection.Close();

            return DB_Connection;

        }

    }
}
