using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Winnie_Learning_Programme.Services
{
    public class PasswordHasher
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("MySecretEncryptionKeyToEncryptPd"); // Replace with a strong key with proper size
        private static readonly byte[] IV = new byte[16]; // Use a different IV for each encryption operation
        private WKDbEntities _context;
        public PasswordHasher(WKDbEntities context)
        {
            _context = context;
        }

        public string EncryptPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var encryptedStream = new System.IO.MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(encryptedStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(passwordBytes, 0, passwordBytes.Length);
                        cryptoStream.FlushFinalBlock();

                        byte[] encryptedPasswordBytes = encryptedStream.ToArray();
                        byte[] combinedBytes = new byte[aes.IV.Length + encryptedPasswordBytes.Length];
                        Array.Copy(aes.IV, 0, combinedBytes, 0, aes.IV.Length);
                        Array.Copy(encryptedPasswordBytes, 0, combinedBytes, aes.IV.Length, encryptedPasswordBytes.Length);

                        return Convert.ToBase64String(combinedBytes);
                    }
                }
            }
        }

        public string DecryptPassword(string encryptedPassword)
        {
            byte[] encryptedPasswordBytes = Convert.FromBase64String(encryptedPassword);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var decryptedStream = new System.IO.MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(decryptedStream, decryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedPasswordBytes, 0, encryptedPasswordBytes.Length);
                        cryptoStream.FlushFinalBlock();

                        byte[] decryptedPasswordBytes = decryptedStream.ToArray();
                        return Encoding.UTF8.GetString(decryptedPasswordBytes);
                    }
                }
            }
        }
    }
}