using System;

public class Solution {
    private static int step = 1;

    public static string InverterText(string s){
        string invertido = "";

        for(int i = (s.Length - 1); i >= 0; i--){
            char caracter = s[i];
            invertido += caracter;
        }

        return invertido;
    }

    public static string IsPalindromo(string original){
        string palindromo = "";
        string teste = "";
        
        for(int i = 0; i < original.Length; i++) {
            char characterInicial = original[i];

            for(int v = original.Length - 1; v > i; v--) {
                char characterAtual = original[v];
                
                DrawState(original, i, v, $"Testando: Inicial '{characterInicial}' | Atual '{characterAtual}'");

                if (characterAtual == characterInicial){
                    teste = original[i..(v + 1)];
                    
                    Console.WriteLine($"\n[!] Letras IGUAIS! Recortando palavra: '{teste}'");
                    Console.WriteLine("Pressione ENTER para inverter e testar...");
                    Console.ReadLine();
                    
                    string textoInvertido = InverterText(teste);
                    
                    if(textoInvertido == teste) {
                        Console.WriteLine($"[RESULTADO] '{teste}' invertido e '{textoInvertido}'. E palindromo!");
                        
                        if (teste.Length > palindromo.Length) {
                            palindromo = teste;
                            Console.WriteLine($"---> NOVO RECORDE: '{palindromo}' (Tamanho {palindromo.Length})");
                        } else {
                            Console.WriteLine($"Mas o recorde atual '{palindromo}' e maior ou igual.");
                        }
                    } else {
                        Console.WriteLine($"[RESULTADO] '{teste}' invertido e '{textoInvertido}'. Nao e palindromo.");
                    }
                    
                    Console.WriteLine("\nPressione ENTER para continuar a busca...");
                    Console.ReadLine();
                }
            }
        }

        return palindromo;
    }

    private static void DrawState(string s, int i, int v, string msg) {
        Console.WriteLine($"\n=========================================");
        Console.WriteLine($"[Passo {step++}] {msg}");
        Console.WriteLine(s);
        
        char[] pointers = new string(' ', s.Length).ToCharArray();
        
        if (i >= 0 && i < s.Length) pointers[i] = 'I';
        if (v >= 0 && v < s.Length) pointers[v] = 'V';
        
        Console.WriteLine(new string(pointers));
        Console.WriteLine($"Inicio (I) = {i} | Fim (V) = {v}");
        Console.WriteLine("Pressione ENTER para avancar...");
        Console.ReadLine();
    }

    public static void Main(string[] args){
        string s = "abaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaabaaba";
        string resposta = IsPalindromo(s);

        Console.WriteLine($"\n=========================================");
        if (resposta == "") {
            Console.WriteLine($"RESPOSTA FINAL: Nao achou palindromos maiores que 1 letra.");
        } else {
            Console.WriteLine($"RESPOSTA FINAL: {resposta}");
        }
    }
}