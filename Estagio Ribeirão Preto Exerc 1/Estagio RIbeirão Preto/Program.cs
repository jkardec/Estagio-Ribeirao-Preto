using System;

internal class Program {
    private static void Main(string[] args) {

        //iniciando as váriaveis.
        int INDICE = 13, SOMA = 0, K = 0;

       /* laço de repetição que incrementa a variável K até que ela seja igual a INDICE = 13,
        e em cada iteração, adiciona o valor de K à variável soma.
        Quando K alcança o valor de INDICE, o laço termina e o valor final da SOMA é impresso.*/

        while (K < INDICE) {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine(SOMA);
        //imprime SOMA ==91.
        
    }
}