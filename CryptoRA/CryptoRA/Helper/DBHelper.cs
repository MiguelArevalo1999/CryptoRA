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
                Console.WriteLine(ex.Message);
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
                                          string apellidos, byte[] streamHuella, byte[] hashHuella,
                                          byte[] pubkey, string esAdmin, byte[] DPbytes,
                                          byte[] DQbytes, byte[] inverseQbytes, byte[] Pbytes, 
                                          byte[] Qbytes,byte[]Dbytes,byte[] Nbytes)
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
                    cmd.Parameters.Add("@streamHuella", MySqlDbType.Blob).Value = streamHuella;
                    cmd.Parameters.Add("@hashHuella", MySqlDbType.Blob).Value = hashHuella;
                    cmd.Parameters.Add("@pubkey", MySqlDbType.Blob).Value = pubkey;
                    cmd.Parameters.Add("@esAdmin", MySqlDbType.VarChar).Value = esAdmin;
                    cmd.Parameters.Add("@DPbytes", MySqlDbType.Blob).Value = DPbytes;
                    cmd.Parameters.Add("@DQbytes", MySqlDbType.Blob).Value = DQbytes;
                    cmd.Parameters.Add("@inverseQbytes", MySqlDbType.Blob).Value = inverseQbytes;
                    cmd.Parameters.Add("@Pbytes", MySqlDbType.Blob).Value = Pbytes;
                    cmd.Parameters.Add("@Qbytes", MySqlDbType.Blob).Value = Qbytes;
                    cmd.Parameters.Add("@Dbytes", MySqlDbType.Blob).Value = Dbytes;
                    cmd.Parameters.Add("@Nbytes", MySqlDbType.Blob).Value = Nbytes;
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
