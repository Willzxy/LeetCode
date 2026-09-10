public class Solution {
    public static string InverterText(string s){
        string invertido = "";

        for(int i = (s.Length - 1); i >= 0; i--){
            char caracter = s[i];
            invertido += caracter;
        }

        return invertido;
    }

    public static void IsPalindromo(string original, ref string invertido , ref string palindromo, ref bool left){
        invertido = InverterText(original);

        if(original == invertido || invertido.Length == 1){
            palindromo = invertido;
        }else {
            left = !left;

            if(left){
                original = original[1..];
            } else {
                original = original[0..^1];
            }

            IsPalindromo(original, ref invertido, ref palindromo, ref left);
        }
    }

    public static void Main(string[] args){
        string s = "abb";
        string invertido = "";
        string palindromo = "";
        bool left = true;
        
        IsPalindromo(s, ref invertido, ref palindromo, ref left);
        Console.WriteLine(palindromo);
    }
}

// Anotação para willian, a arquitetura desta solução não vai resolver o problema. vamos usar o que aprender de recursão mas e recomeçar o projeto. vamos passar a usar um Loop While para resolver este exercicio 09/09