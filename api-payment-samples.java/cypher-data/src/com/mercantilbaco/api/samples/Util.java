package com.mercantilbaco.api.samples;

import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Arrays;
import java.util.Base64;
import javax.crypto.Cipher;
import javax.crypto.spec.SecretKeySpec;

public class Util {
	
	private byte[] key;
	private SecretKeySpec secretKey;

	public String encrypt(String masterkey, String strToEncrypt) {
		try
		{
			setKey(masterkey);
			Cipher cipher = Cipher.getInstance("AES/ECB/PKCS5Padding");
			cipher.init(Cipher.ENCRYPT_MODE, secretKey);
			return Base64.getEncoder().encodeToString(cipher.doFinal(strToEncrypt.getBytes("UTF-8")));
		}
		catch (Exception e)
		{
			e.printStackTrace();
		}
		return null;
	}
	/*
	 * 
	 */
	public String decrypt(String masterkey, String strToDecrypt) {

		try
		{
			setKey(masterkey);
			Cipher cipher = Cipher.getInstance("AES/ECB/PKCS5PADDING");
			cipher.init(Cipher.DECRYPT_MODE, secretKey);
			return new String(cipher.doFinal(Base64.getDecoder().decode(strToDecrypt)));
		}
		catch (Exception e)
		{
			e.printStackTrace();
		}
		return null;
	}

	private  void setKey(String myKey)
	{
		MessageDigest sha = null;
		try {
			key = myKey.getBytes("UTF-8");
			sha = MessageDigest.getInstance("SHA-256");
			key = sha.digest(key);
			key = Arrays.copyOf(key, 16);		
			secretKey = new SecretKeySpec(key, "AES");
		
		}
		catch (NoSuchAlgorithmException e) 
		{
			e.printStackTrace();
		}
		catch (UnsupportedEncodingException e) 
		{
			e.printStackTrace();
		}
	}
}
