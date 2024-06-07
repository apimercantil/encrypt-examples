package com.bancomercantil.crypto;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.security.InvalidKeyException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Arrays;
import java.util.Base64;

import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.spec.SecretKeySpec;

class Crypto {

    final static String cypherInstance = "AES/ECB/PKCS5Padding";
    private static byte[] key;
	private static SecretKeySpec secretKey;

    /**
	 * Purpose: Cifrar/Descifrar archivo
	 * 
	 * @param cipherMode integer
	 * @param key String
	 * @param inputFile File
	 * @param outputFile File
	 * @return boolean
	 */
	public static boolean fileProcessorB64(int cipherMode, String masterkey, File inputFile, File outputFile){

		boolean bRetorno = true;

		String sResultado = "";

		try 
		{
			setKey(masterkey);

			//AES/ECB/PKCS5PADDING  AES 128 bit Encryption in ECB Mode (Electronic Code Book Mode ) PKCS5PADDING
			Cipher cipher = Cipher.getInstance(cypherInstance);					

			cipher.init(cipherMode, secretKey);

			System.out.println("fileProcessorB64_API(). Inicio");
			
			byte[] bytesArchivo = LeerArchivoCompletoBytes(inputFile);
			
			String contenido = new String(bytesArchivo);

			System.out.println("fileProcessorB64_API(). contenido");
			
			if (cipherMode == 1)
			{
				sResultado = Base64.encodeBase64String(cipher.doFinal(contenido.getBytes("UTF-8")));	
			}
			else if (cipherMode == 2)
			{
				sResultado = new String(cipher.doFinal(Base64.decodeBase64(contenido)));
			}

			System.out.println("fileProcessorB64_API(). sResultado");
			
			byte[] outputBytes = sResultado.getBytes("UTF-8");

			//GUARDAR RESULTADO
			FileOutputStream outputStream = new FileOutputStream(outputFile);
			outputStream.write(outputBytes);

			outputStream.close();			
		} 
		catch (NoSuchPaddingException e) 
		{
			e.printStackTrace();

			bRetorno = false;
		}
		catch (NoSuchAlgorithmException e) 
		{
			e.printStackTrace();

			bRetorno = false;
		}
		catch (InvalidKeyException e) 
		{
			e.printStackTrace();

			bRetorno = false;
		}
		catch (BadPaddingException e) 
		{
			e.printStackTrace();

			bRetorno = false;
		}
		catch (IllegalBlockSizeException e) 
		{
			e.printStackTrace();

			bRetorno = false;
		}
		catch (IOException e) 
		{
			e.printStackTrace();

			bRetorno = false;
		}

		System.out.println("fileProcessorB64(). Fin. bRetorno: " + bRetorno);
		
		return bRetorno;
	}

    /*
     * Purpose: Procesar la llave de cifrado al formato correcto para su uso.
     * 
     * @params myKey String
     */

    private static void setKey(String myKey)
	{
		MessageDigest sha = null;

		try {
			key = myKey.getBytes("UTF-8");
			sha = MessageDigest.getInstance("SHA-256");
			key = sha.digest(key_API);
			key = Arrays.copyOf(key_API, 16);
			secretKey = new SecretKeySpec(key, "AES");
		}
		catch (NoSuchAlgorithmException e) {
			e.printStackTrace();
		}
		catch (UnsupportedEncodingException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Purpose: Leer archivo y retornar array de bytes
	 * 
	 * @param file
	 * @return array
	 */
	public static byte[] LeerArchivoCompletoBytes(File file)
	{
		//init array with file length
		byte[] bytesArray = new byte[(int) file.length()]; 

		try
		{
			FileInputStream fis = new FileInputStream(file);
			fis.read(bytesArray); //read file into bytes[]
			fis.close();
		}
		catch (Exception e)
		{
			System.out.println("LeerArchivoCompletoBytes(). Error: " + e.getMessage());

			System.out.println("LeerArchivoCompletoBytes(). Archivo: " + file.getPath());
		}
		return bytesArray;
	}
}