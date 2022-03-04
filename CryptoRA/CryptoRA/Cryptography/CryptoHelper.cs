using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoRA.Cryptography
{
    public static class CryptoHelper
    {
        public static byte[] ComputeHash512(byte[] streamHuella)
        {
            byte[] data = new byte[streamHuella.Length];
            byte[] result;
            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(data);

            return result;

        }

    }
}
