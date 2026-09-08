using System;

namespace app {
    public class program {
        public static void Main(string[] args){
            int[] l1 = [2,4,3];
            int[] l2 = [5,6,4];
            int maior = l1.Length >= l2.Length? l1.Length: l2.Length;
            int result = 0;
            int mult = 1;

            for(int i = 0; i < maior; i++){
                if(i <= l1.Length){
                    result += l1[i] * mult;     
                }

                if (i <= l2.Length){
                    result += l2[i] * mult;  
                }

                mult *= 10;
            }

            List<int>? returned = new();
            
        }
    }
}