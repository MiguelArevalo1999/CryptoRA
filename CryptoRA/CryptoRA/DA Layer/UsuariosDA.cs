using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CryptoRA.Helper;
using System.Data;
using System.Windows.Forms;

namespace CryptoRA.DA_Layer
{
    public static class UsuariosDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;
        

        public  static Usuario RegresaUsuario(string nombreUsuario)
        {
            string query = "SELECT * FROM cryptora.users WHERE nombreUsuario = (@nombreUsuario)";
            cmd = DBHelper.RunQuery(query,nombreUsuario);

            Usuario aUsuario = null;

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    string uNombreUsuario = dataRow["nombreUsuario"].ToString();
                    string uCorreo = dataRow["correo"].ToString();
                    string uNombre = dataRow["Nombre"].ToString();
                    string uApellidos = dataRow["Apellidos"].ToString();
                    byte[] uTemplate = (byte[])dataRow["Template"];
                    byte[] uHuella = (byte[])dataRow["Huella"];
                    byte[] ullavePublica = (byte[])dataRow["llavePublica"];
                    bool uIsAdmin = dataRow["esAdmin"].ToString().Equals("True");
                    string uImagenPerfil = dataRow["imagenPerfil"].ToString();
                    byte[] uDP = (byte[])dataRow["DP"];
                    byte[] uDQ = (byte[])dataRow["DQ"];
                    byte[] uInverseQ = (byte[])dataRow["InverseQ"];
                    byte[] uP = (byte[])dataRow["P"];
                    byte[] uQ = (byte[])dataRow["Q"];
                    byte[] uD = (byte[])dataRow["D"];
                    byte[] uN = (byte[])dataRow["N"];


                    aUsuario = new Usuario(uNombreUsuario,uCorreo,uNombre,uApellidos,uTemplate,uHuella,ullavePublica,uIsAdmin,uImagenPerfil,uDP,uDQ,uInverseQ,uP,uQ,uD,uN);
                }
            }

            return aUsuario;
        }

        public static DataTable RegresaTabla()
        {
            string query = "SELECT nombreUsuario,correo,Nombre,Apellidos,esAdmin," +
                           "imagenPerfil FROM cryptora.users";
            cmd = DBHelper.RunQueryPopulate(query);

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            return dt;
        }
        public static DataTable TablaLlavePublica()
        {
            string query = "SELECT nombreUsuario,correo,Nombre,Apellidos FROM cryptora.users";
            cmd = DBHelper.RunQueryPopulate(query);

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            return dt;
        }

        public static byte[] RegresaTemplate(string nombreUsuario)
        {
            string query = "SELECT Template FROM cryptora.users WHERE nombreUsuario = (@nombreUsuario)";
            cmd = DBHelper.RunQuery(query, nombreUsuario);

            byte[] uTemplate = null;

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    uTemplate = (byte[])dataRow["Template"];
                }
            }

            return uTemplate;
        }

        public static void InsertaUsuario(string nombreUsuario,
                                          string correo, string nombre,
                                          string apellidos,byte[] streamHuella,
                                          byte[] hashHuella,byte[] pubkey, string esAdmin, 
                                          byte[] DPbytes, byte[] DQbytes, byte[] inverseQbytes, byte[] Pbytes, 
                                          byte[] Qbytes,byte[]Dbytes,byte[] Nbytes)
        {
            string query = "INSERT INTO cryptora.users (nombreUsuario,correo,Nombre," +
                                                    "Apellidos,Template,Huella,llavePublica,esAdmin,DP,DQ,InverseQ,P,Q,D,N)" +
                                                    "VALUES(@nombreUsuario,@correo,@nombre,@apellidos,@streamHuella,@hashHuella,@pubkey,@esAdmin," +
                                                    "@DPbytes,@DQbytes,@inverseQbytes,@Pbytes,@Qbytes,@Dbytes,@Nbytes)";
            
            cmd = DBHelper.InsertQuery(query, nombreUsuario,correo,nombre,apellidos,streamHuella, 
                                        hashHuella,pubkey,esAdmin,DPbytes,DQbytes,inverseQbytes,Pbytes,
                                        Qbytes,Dbytes, Nbytes);

                Console.WriteLine(query);
        }
    }
}
