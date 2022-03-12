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
                    byte[] uHuella = (byte[])dataRow["Huella"];
                    bool uIsAdmin = dataRow["esAdmin"].ToString().Equals("True");
                    string uImagenPerfil = dataRow["imagenPerfil"].ToString();
                    byte[] uDP = (byte[])dataRow["DP"];
                    byte[] uDQ = (byte[])dataRow["DQ"];
                    byte[] uInverseQ = (byte[])dataRow["InverseQ"];
                    byte[] uP = (byte[])dataRow["P"];
                    byte[] uQ = (byte[])dataRow["Q"];


                    aUsuario = new Usuario(uNombreUsuario,uCorreo,uNombre,uApellidos,uHuella,uIsAdmin,uImagenPerfil,uDP,uDQ,uInverseQ,uP,uQ);
                }
            }

            return aUsuario;
        }

        public static void InsertaUsuario(string nombreUsuario,
                                          string correo, string nombre,
                                          string apellidos,byte[] hashHuella, 
                                          byte[] pubkey, string esAdmin, byte[] DPbytes, 
                                          byte[] DQbytes, byte[] inverseQbytes, byte[] Pbytes, byte[] Qbytes)
        {
            string query = "INSERT INTO cryptora.users (nombreUsuario,correo,Nombre," +
                                                    "Apellidos,Huella,llavePublica,esAdmin,DP,DQ,InverseQ,P,Q)" +
                                                    "VALUES(@nombreUsuario,@correo,@nombre,@apellidos,@hashHuella,@pubkey,@esAdmin," +
                                                    "@DPbytes,@DQbytes,@inverseQbytes,@Pbytes,@Qbytes)";
            
            cmd = DBHelper.InsertQuery(query, nombreUsuario,correo,nombre,apellidos,hashHuella,pubkey,esAdmin
                                        ,DPbytes,DQbytes,inverseQbytes,Pbytes,Qbytes);

                Console.WriteLine(query);
        }
    }
}
