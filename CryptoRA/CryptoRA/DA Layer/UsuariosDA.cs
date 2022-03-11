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

                    

                    aUsuario = new Usuario(uNombreUsuario,uCorreo,uNombre,uApellidos,uHuella,uIsAdmin,uImagenPerfil);
                }
            }

            return aUsuario;
        }

        public static void InsertaUsuario(string nombreUsuario,
                                          string correo, string nombre,
                                          string apellidos,byte[] hashHuella, 
                                          byte[] pubkey, string esAdmin)
        {
            string query = "INSERT INTO cryptora.users (nombreUsuario,correo,Nombre," +
                                                    "Apellidos,Huella,llavePublica,esAdmin)" +
                                                    "VALUES(@nombreUsuario,@correo,@nombre,@apellidos,@hashHuella,@pubkey,@esAdmin)";
            
            cmd = DBHelper.InsertQuery(query, nombreUsuario,correo,nombre,apellidos,hashHuella,pubkey,esAdmin);

                Console.WriteLine(query);
        }
    }
}
