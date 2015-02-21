using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace KeyPassBusiness
{
	public static class CryptoHelper
	{
		public static byte[] Encrypt(byte[] plainTextBytes)
		{
			PasswordDeriveBytes pd = new PasswordDeriveBytes("FooBarMeow", new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
			MemoryStream ms = new MemoryStream();
			Rijndael alg = Rijndael.Create();
			alg.Key = pd.GetBytes(32);
			alg.IV = pd.GetBytes(16);
			CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
			cs.Write(plainTextBytes, 0, plainTextBytes.Length);
			cs.Close();
			return ms.ToArray();
		}

		public static byte[] Decrypt(byte[] cipherTextBytes)
		{
			PasswordDeriveBytes pd = new PasswordDeriveBytes("FooBarMeow", new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
			MemoryStream ms = new MemoryStream();
			Rijndael alg = Rijndael.Create();
			alg.Key = pd.GetBytes(32);
			alg.IV = pd.GetBytes(16);
			CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
			cs.Write(cipherTextBytes, 0, cipherTextBytes.Length);
			cs.Close();
			return ms.ToArray();
		}
	}
}
