internal class Program {
    private static void Main(string[] args) {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        //função com valor digitado pelo usuário como argumento e armazenado na variavel "numero".
        bool pertence = VerificaSePertence(numero);
        
        if (pertence)
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");

           
        /* função estatica que retorna true ou false.
           que calcula a sequência de Fibo */
     static bool VerificaSePertence(int num) {
            int a = 0;
            int b = 1;

            while (b < num) {
                int aux = a;
                a = b;
                b = aux + b;
            }
            //após o loop se for verdadeiro "num" esta na sequencia de Fibo.
            return b == num;
     }

        
    }
}