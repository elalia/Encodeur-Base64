# Encodeur-Base64
Ce projet .NET en C# consiste a creer une classe statique « Base64 » exposant la méthode suivante :
public static string Encode(byte[] source)
La méthode recevra en paramètre un tableau d’octets à encoder.
Le tableau aura une longueur qui sera un multiple de 3 afin de simplifier le test.
Le tableau d’octets reçus doit être encodé en suivant la procédure décrite à la section 4, et le
résultat final doit être retourné dans une chaine de caractères (string).
