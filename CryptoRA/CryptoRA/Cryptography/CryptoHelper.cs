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
            byte[] data = new byte[streamHuella.Length];
            byte[] result;
            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(data);

            return result;
        }

        public static BigInteger getPublicKey(byte[] hashHuella)
        {
            BigInteger hashHuella_BigInt = new BigInteger(hashHuella);
            
            if (hashHuella_BigInt.IsEven) { hashHuella_BigInt++; }
            
            Console.WriteLine("HashBigInt: " + hashHuella_BigInt);
            BigInteger publickey =  generatePublicKey(hashHuella_BigInt);
            
            return publickey;
        }

        public static BigInteger generatePublicKey(BigInteger hashHuella_BigInt)
        {
            bool correctPrimes = true;
            BigInteger pubkey = 0;

            while (correctPrimes)
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

                var a = rsa.ExportParameters(true);
                BigInteger p = new BigInteger(a.P.Reverse().Concat(new byte[1]).ToArray());
                BigInteger q = new BigInteger(a.Q.Reverse().Concat(new byte[1]).ToArray());
                BigInteger n = new BigInteger(a.Modulus.Reverse().Concat(new byte[1]).ToArray());
                Console.WriteLine(p * q == n);
                Console.WriteLine("p: " + p);
                Console.WriteLine("q: " + q);
                Console.WriteLine("n: " + n);
                Console.WriteLine("Phi(n): " + Phi(p, q));

                pubkey = ModInverse(hashHuella_BigInt, Phi(p, q));
                if((pubkey * hashHuella_BigInt)%Phi(p,q) == 1)
                {
                    Console.WriteLine("Pubkey: " + pubkey);
                    correctPrimes = false;
                }

            }
            return pubkey;
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
            Console.WriteLine(gcd);
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



    }
}
