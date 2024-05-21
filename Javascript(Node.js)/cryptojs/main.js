const CryptoJS = require("crypto-js");

function encryptAES256(message, key) {
    // Convertir la llave secreta en un hash SHA256
    const cipherKey = CryptoJS.SHA256(CryptoJS.enc.Utf8.parse(key));

    // OBTENER LOS PRIMEROS 16 BYTES DEL HASH
    const keyString = cipherKey.toString();
    const firstHalf = keyString.slice(0, keyString.length / 2);
    const keyHex = CryptoJS.enc.Hex.parse(firstHalf);

    // ENCRIPTACION DEL MENSAJE USANDO LA CLAVE NUEVA    
    const encrypt = CryptoJS.AES.encrypt(message, keyHex, {
      mode: CryptoJS.mode.ECB,
      padding: CryptoJS.pad.Pkcs7
    });

    return CryptoJS.enc.Base64.stringify(encrypt.ciphertext); // VALOR DEVUELTO EN BASE64
}

function decryptAES256(message, key) {
    // Convertir la llave secreta en un hash SHA256
    const cipherKey = CryptoJS.SHA256(CryptoJS.enc.Utf8.parse(key));

    // OBTENER LOS PRIMEROS 16 BYTES DEL HASH
    const keyString = cipherKey.toString();
    const firstHalf = keyString.slice(0, keyString.length / 2);
    const keyHex = CryptoJS.enc.Hex.parse(firstHalf);

    // Codificar el mensaje a Base64
    const cipherBytes = CryptoJS.enc.Base64.parse(message)

    // ENCRIPTACION DEL MENSAJE USANDO LA CLAVE NUEVA    
    const decrypt = CryptoJS.AES.decrypt({ciphertext: cipherBytes}, keyHex, {
        mode: CryptoJS.mode.ECB,
        padding: CryptoJS.pad.Pkcs7
      });

    return CryptoJS.enc.Utf8.stringify(decrypt); // VALOR DEVUELTO EN UTF8
}