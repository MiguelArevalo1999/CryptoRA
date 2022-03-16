using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRA
{
    public class Usuario
    {
       

        public  Usuario(string nombreUsuario, string correo, string nombre, 
                        string apellidos, byte[] template, byte[] huella,byte[] llavepublica, bool isadmin,string imagenperfil, byte[] dp, byte[] dq
                        , byte[] inverseq, byte[] p, byte[] q,byte[]d,byte[]n)
        {
            NombreUsuario = nombreUsuario;
            Correo = correo;
            Nombre = nombre;
            Apellidos = apellidos;
            Template = template;
            Huella = huella;
            llavePublica = llavepublica;
            isAdmin = isadmin;
            imagenPerfil = imagenperfil;
            DP = dp;
            DQ = dq;
            InverseQ = inverseq;
            P = p;
            Q = q;
            D = d;
            N = n;


        }

        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public byte[] Template { get; set; }
        public byte[] Huella { get; set; }
        public byte[] llavePublica { get; set; }
        public bool isAdmin { get; set; }
        public string imagenPerfil { get; set; }
        public byte[] DP { get; set; }
        public byte[] DQ { get; set; }
        public byte[] InverseQ { get; set; }
        public byte[] P { get; set; }
        public byte[] Q { get; set; }
        public byte[] D { get; set; }
        public byte[] N { get; set; }




    }
}
