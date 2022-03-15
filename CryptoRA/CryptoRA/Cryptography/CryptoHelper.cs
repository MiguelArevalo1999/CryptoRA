using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;


namespace CryptoRA.Cryptography
{
    public static class CryptoHelper
    {
        public static byte[] ComputeHash512(byte[] streamHuella)
        {
            using (SHA512 sha = new SHA512Managed())
            {
                return sha.ComputeHash(streamHuella);
            }
        }

        public static RSAParameters getAsymmetricParameters(byte[] hashHuella)
        {
            BigInteger privateKey = getPrivateKey(hashHuella);
            RSAParameters asymmetricParameters = generateAsymmetricParameters(privateKey);
            
            return asymmetricParameters;
        }

        public static BigInteger getPrivateKey(byte[] hashHuella)
        {
            BigInteger privateKey = new BigInteger(hashHuella);

            if (privateKey.IsEven) { privateKey++; }
            return privateKey;
        }

        public static RSAParameters generateAsymmetricParameters(BigInteger hashHuella_BigInt)
        {
            bool correctPrimes = true;
            BigInteger pubkey = 0;

            RSAParameters rsaParameters = new RSAParameters();

            while (correctPrimes)
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

                var a = rsa.ExportParameters(true);
                BigInteger p = new BigInteger(a.P.Reverse().Concat(new byte[1]).ToArray());
                BigInteger q = new BigInteger(a.Q.Reverse().Concat(new byte[1]).ToArray());
                BigInteger n = new BigInteger(a.Modulus.Reverse().Concat(new byte[1]).ToArray());
                //Console.WriteLine(p * q == n);
                //Console.WriteLine("p: " + p);
                //Console.WriteLine("q: " + q);
                //Console.WriteLine("n: " + n);
                //Console.WriteLine("Phi(n): " + Phi(p, q));

                pubkey = ModInverse(hashHuella_BigInt, Phi(p, q));
                if((pubkey * hashHuella_BigInt)%Phi(p,q) == 1)
                {
                    //a.D = hashHuella_BigInt.ToByteArray();
                    //a.DP = (hashHuella_BigInt%(p-1)).ToByteArray();
                    //a.DQ = (hashHuella_BigInt % (q - 1)).ToByteArray();

                    correctPrimes = false;
                    rsaParameters = a;
                    
                }

            }
            return rsaParameters;

        }
     
        public static BigInteger Phi(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        public static BigInteger Egcd(BigInteger left,
                              BigInteger right,
                          out BigInteger leftFactor,
                          out BigInteger rightFactor)
        {
            leftFactor = 0;
            rightFactor = 1;
            BigInteger u = 1;
            BigInteger v = 0;
            BigInteger gcd = 0;

            while (left != 0)
            {
                BigInteger q = right / left;
                BigInteger r = right % left;

                BigInteger m = leftFactor - u * q;
                BigInteger n = rightFactor - v * q;

                right = left;
                left = r;
                leftFactor = u;
                rightFactor = v;
                u = m;
                v = n;

                gcd = right;
            }
            //Console.WriteLine(gcd);
            return gcd;
        }

        public static BigInteger ModInverse(BigInteger value, BigInteger modulo)
        {
            BigInteger x, y;

            if (1 != Egcd(value, modulo, out x, out y))
                return 0;

            if (x < 0)
                x += modulo;

            return x % modulo;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }



    }
}
