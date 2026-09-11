public class Solution {
    public static string InverterText(string s){
        string invertido = "";

        for(int i = (s.Length - 1); i >= 0; i--){
            char caracter = s[i];
            invertido += caracter;
        }

        return invertido;
    }

    public static string IsPalindromo(string original){
        string copia = "";
        string palindromo = "";

        for(int i = 0; i < original.Length; i++) {
            char characterInicial = original[i];
            string teste = "" + characterInicial;
            for(int v = i+1; v <= original.LastIndexOf(characterInicial); v++) {
                char other = original[v];
                teste += other;
            }

            Console.WriteLine($"Teste {i}, Iniciando com letra{characterInicial}, Frase = {teste} ");
            if(InverterText(teste) == teste && teste.Length > palindromo.Length) {
                palindromo = teste;
            }
        }


        return palindromo;
    }

    public static void Main(string[] args){
        string s = "aacabdkacaa";
        string palindromo = IsPalindromo(s);

        Console.WriteLine($"\nrespota: {palindromo}");
    }
}

// Anotação para willian, a arquitetura desta solução não vai resolver o problema. vamos usar o que aprender de recursão mas e recomeçar o projeto. vamos passar a usar um Loop While para resolver este exercicio 09/09