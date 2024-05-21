const Crypto = require("crypto");

function encryptAES256(message, key) {
    const algorythm = "aes-128-ecb";
    // Convertir la llave secreta en un hash SHA256
    const hash = Crypto.createHash('sha256')
    hash.update(key)
    
    // Obtener los primeros 16 bytes del hash
    const keyString = hash.copy().digest("hex")
    const firstHalf = keyString.toString().slice(0, keyString.length / 2);
    const keyHex = Buffer.from(firstHalf, 'hex');
    
    // Generacion del vector de inicializacion(necesario para la encriptacion del mensaje)
    const iv = Crypto.randomBytes(0);
    
    // Encriptacion del mensaje usando la clave nueva
    const cipher = Crypto.createCipheriv(algorythm, keyHex, iv);
  
    let ciphertext = cipher.update(message, 'utf8', 'base64');
    ciphertext += cipher.final('base64');

    return ciphertext; // Valor devuelto en base64
}

function decryptAES256(message, key) {
    const algorythm = "aes-128-ecb";
    // Convertir la llave secreta en un hash SHA256
    const hash = Crypto.createHash('sha256')
    hash.update(key)
    
    // Obtener los primeros 16 bytes del hash
    const keyString = hash.copy().digest("hex")
    const firstHalf = keyString.toString().slice(0, keyString.length / 2);
    const keyHex = Buffer.from(firstHalf, 'hex');
    
    // Generacion del vector de inicializacion(necesario para la encriptacion del mensaje)
    const iv = Crypto.randomBytes(0);
    
    // Encriptacion del mensaje usando la clave nueva
    const decipher = Crypto.createDecipheriv(algorythm, keyHex, iv);
  
    let deciphertext = decipher.update(message, 'base64', 'utf8');
    deciphertext += decipher.final('utf8');

    return deciphertext; // Valor devuelto en utf8
}