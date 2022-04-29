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
            if(privateKey < 0) { privateKey = -privateKey; }
            if (privateKey.IsEven) { privateKey++; }
            return privateKey;
        }

        public static RSAParameters generateAsymmetricParameters(BigInteger hashHuella_BigInt)
        {
           
            BigInteger pubkey = 0;

            var rsa = new RSACng(2048);
            var a = rsa.ExportParameters(true);

            BigInteger p = new BigInteger(a.P.Reverse().Concat(new byte[1]).ToArray());
            BigInteger q = new BigInteger(a.Q.Reverse().Concat(new byte[1]).ToArray());
            BigInteger n = new BigInteger(a.Modulus.Reverse().Concat(new byte[1]).ToArray());
            BigInteger dp = new BigInteger(a.DP.Reverse().Concat(new byte[1]).ToArray());
            BigInteger dq = new BigInteger(a.DQ.Reverse().Concat(new byte[1]).ToArray());
            BigInteger invq = new BigInteger(a.InverseQ.Reverse().Concat(new byte[1]).ToArray());
            BigInteger d = new BigInteger(a.D.Reverse().Concat(new byte[1]).ToArray());


            Console.WriteLine("HuellaBigInt: " + hashHuella_BigInt);
            Console.WriteLine(p * q == n);
            Console.WriteLine("p: " + p);
            Console.WriteLine("q: " + q);
            Console.WriteLine("n: " + n);
            Console.WriteLine("invQ: " + invq);
            Console.WriteLine("Phi(n): " + Phi(p, q));
            //Console.WriteLine("dp(0): " + dp);
            //Console.WriteLine("dq(0): " + dq);
            //Console.WriteLine(dp == d % (p - 1));
            //Console.WriteLine(dq == d % (q - 1));

            pubkey = ModInverse(hashHuella_BigInt, Phi(p, q));
            Console.WriteLine("Pubkey: " + pubkey);

            BigInteger remainder1;
            BigInteger remainder2;
            remainder1 = BigInteger.Remainder(hashHuella_BigInt, p - 1);
            remainder2 = BigInteger.Remainder(hashHuella_BigInt, q - 1);

            a.P = p.ToByteArray();
            a.Q = q.ToByteArray();
            a.InverseQ = invq.ToByteArray();
            a.Modulus = n.ToByteArray();
            a.Exponent = pubkey.ToByteArray();
            a.D = hashHuella_BigInt.ToByteArray();
            a.DP = remainder1.ToByteArray();
            a.DQ = remainder2.ToByteArray();


            Console.WriteLine("dp: " + remainder1);
            Console.WriteLine("dq: " + remainder2);
            Console.WriteLine(remainder1 == hashHuella_BigInt % (p - 1));
            Console.WriteLine(remainder2 == hashHuella_BigInt % (q - 1));

            Console.WriteLine("d * e % Phi(n): " + (pubkey * hashHuella_BigInt) % Phi(p, q));

            return a;

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
