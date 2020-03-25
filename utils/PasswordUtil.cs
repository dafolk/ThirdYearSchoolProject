using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.utils
{
    class PasswordUtil
    {
        private const int hashBytes = 18;
        private const int saltBytes = 24;
        private const int iterations = 64000;

        public string CreateHash(string password)
        {
            byte[] salt = new byte[saltBytes];
            Random random = new Random();
            random.NextBytes(salt);
            Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(password, salt, iterations);
            return "sha1:" + Convert.ToString(iterations) + ":" + Convert.ToString(hashBytes) + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash.GetBytes(hashBytes));
        }

        public Boolean VerifyHash(string password, string hashString)
        {
            string[] frames = hashString.Split(':');
            string _algorithm = frames[0];
            int _iterations = Convert.ToInt32(frames[1]);
            int _hashBytes = Convert.ToInt32(frames[2]);
            byte[] salt = Convert.FromBase64String(frames[3]);
            string hash = frames[4];
            string generatedHash = Convert.ToBase64String(new Rfc2898DeriveBytes(password, salt, _iterations).GetBytes(_hashBytes));
            return generatedHash.Equals(hash);
        }
        /*
        public static void Main()
 	    {
            string password = "admin";
            PasswordUtil hasher = new PasswordUtil();
 		    string hash = hasher.CreateHash(password);
 		    Boolean verify = hasher.VerifyHash("admin", hash);
 		    Console.WriteLine("hash: " + hash);
 		    Console.WriteLine("Password matches hash: " + verify);
 	    }
        */
    }
}