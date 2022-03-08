using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CryptoRA.Helper
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand  cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "127.0.0.1";
                builder.UserID = "root";
                builder.Password = "e4e5Cf3Cc6Ab5+";
                builder.Database = "cryptora";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }

        public static MySqlCommand RunQuery(string query, string username)
        {

            try
            {
                if (connection != null) 
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nombreUsuario", username);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return cmd;
        }

        public static MySqlCommand InsertQuery(string query, string nombreUsuario,
                                          string correo, string nombre,
                                          string apellidos, byte[] hashHuella,
                                          byte[] pubkey, string esAdmin)
        {

            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@nombreUsuario", MySqlDbType.VarChar).Value = nombreUsuario;
                    cmd.Parameters.Add("@correo", MySqlDbType.VarChar).Value = correo;
                    cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre;
                    cmd.Parameters.Add("@apellidos", MySqlDbType.VarChar).Value = apellidos;
                    cmd.Parameters.Add("@hashHuella", MySqlDbType.Blob).Value = hashHuella;
                    cmd.Parameters.Add("@pubkey", MySqlDbType.Blob).Value = pubkey;
                    cmd.Parameters.Add("@esAdmin", MySqlDbType.VarChar).Value = esAdmin;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return cmd;
        }
    }
}
