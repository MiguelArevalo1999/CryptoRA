﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRA
{
    public class Usuario
    {
        private string nombreUsuario;
        private string correo;
        private string nombre;
        private string apellidos;
        private string huella;
        private string llavepub;
        private bool isadmin;
        private string imagenperfil;

        public  Usuario(string nombreUsuario, string correo, string nombre, 
                        string apellidos,byte[] huella, bool isadmin,string imagenperfil, byte[] dp, byte[] dq
                        , byte[] inverseq, byte[] p, byte[] q)
        {
            NombreUsuario = nombreUsuario;
            Correo = correo;
            Nombre = nombre;
            Apellidos = apellidos;
            Huella = huella;
            isAdmin = isadmin;
            imagenPerfil = imagenperfil;
            DP = dp;
            DQ = dq;
            InverseQ = inverseq;
            P = p;
            Q = q;


        }


        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public byte[] Huella { get; set; }

        public string llavePublica { get; set; }
        public bool isAdmin { get; set; }
        public string imagenPerfil { get; set; }

        public byte[] DP { get; set; }

        public byte[] DQ { get; set; }

        public byte[] InverseQ { get; set; }
        public byte[] P { get; set; }

        public byte[] Q { get; set; }




    }
}
