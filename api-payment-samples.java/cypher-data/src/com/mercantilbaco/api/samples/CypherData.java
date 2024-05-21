package com.mercantilbaco.api.samples;

public class CypherData {

	public static void main(String[] args) {

		String secretkey = ""; // LLAVE DE CIFRADO
		String cvv = "1111";
		String secondfactor = "3030";
		String authtype = "clavetelefonica";
		try {

			for (int j = 0; j < args.length; j++) {	 

				String param = args[j];
				
				switch(param) 
				{
				case "--secretkey":
					secretkey = args[j+1];
					break;
				case "--cvv":
					cvv = args[j+1];
					break;
				case "--sfactor": 
					secondfactor = args[j+1];
					break;
				case "--authtype": 
					authtype= args[j+1];
					break;
				default:
					break;
				}
			}
		} 
		catch (Exception ex ) {
			System.out.println("Parametros errados");
		}
		Util util = new Util();
		System.out.println("Secret key = " + secretkey);
		/*
		 * 
		 * Encriptando datos
		 * 
		 */	
		System.out.println("*** Encriptando datos ***");		
		/* CVV */
		String encrypCVV = util.encrypt(secretkey,cvv);
		System.out.println("CVV (cvv) = " + encrypCVV);

		/* Segundo factor de authtenticacion */		
		String encrypTA = util.encrypt(secretkey,authtype);
		System.out.println("Tipo de segundo factor(twofactor_type) = " + encrypTA);

		/* Segundo factor de authtenticacion */
		String encrypTF = util.encrypt(secretkey,secondfactor);
		System.out.println("Segundo Factor (twofactor_auth) = " + encrypTF);
		/*
		 * 
		 * Desencriptando datos
		 * 
		 */
		System.out.println("*** Desencriptando datos ***");
		String decryptCVV = util.decrypt(secretkey, encrypCVV);
		System.out.println("CVV (cvv) = " + decryptCVV);		

		String decryptTA = util.decrypt(secretkey,encrypTA);
		System.out.println("Tipo de segundo factor(twofactor_type) = " + decryptTA);

		String decryptTF = util.decrypt(secretkey, encrypTF);
		System.out.println("Segundo Factor (twofactor_auth) = " + decryptTF);

	}
}
