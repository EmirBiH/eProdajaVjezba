using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_UI.Util
{
    public class UIHelper
    {
        public static string GenerateSalt()
        {
            byte[] arr = new byte[16];

            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetBytes(arr);
            return Convert.ToBase64String(arr);
        }

        public static string GenerateHash(string lozinka,string salt)
        {
            byte[] byteLozinka = Encoding.Unicode.GetBytes(lozinka);
            byte[] byteSalt = Convert.FromBase64String(salt);
            byte[] forHashing = new byte[byteLozinka.Length + byteSalt.Length];

            Buffer.BlockCopy(byteLozinka, 0, forHashing, 0, byteLozinka.Length);
            Buffer.BlockCopy(byteSalt, 0, forHashing, byteLozinka.Length, byteSalt.Length);

            HashAlgorithm alg = HashAlgorithm.Create("SHA1");

            return Convert.ToBase64String(alg.ComputeHash(forHashing));
        }

    }
}
