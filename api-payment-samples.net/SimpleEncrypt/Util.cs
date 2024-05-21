using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace com.mercantilbanco.api.sample
{
    class Util
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;
        /// <summary>
        /// Metodo para cifrar datos en AES con bloques de 128
        /// </summary>
        /// <param name="secretkey">Clave utilizada para cifrar los datos</param>
        /// <param name="datatocypher">Datos para ser cifrados</param>
        /// <returns></returns>
        public string Encrypt(String secretkey, string datatocypher)
        {            
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = ComputeSha256Hash(secretkey); 
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode =  CipherMode.ECB;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(datatocypher);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }
        /// <summary>
        /// Metodo para descifrar datos en AES con bloques de 128
        /// </summary>
        /// <param name="secretkey">Clave utilizada para descifrar los datos</param>
        /// <param name="datatodecrpyt">Datos para ser descifrados</param>
        /// <returns></returns>

        public string Decrypt(String secretkey, string datatodecrpyt)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(datatodecrpyt);

            using (Aes aes = Aes.Create())
            {
                aes.Key = ComputeSha256Hash(secretkey);
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.ECB;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

   
        private byte[] ComputeSha256Hash(string rawData)
        {
            
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] key = new byte[16];
                byte[] hash= sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                Array.Copy(hash,key, 16);
                return key;
            }
        }
    }
}
