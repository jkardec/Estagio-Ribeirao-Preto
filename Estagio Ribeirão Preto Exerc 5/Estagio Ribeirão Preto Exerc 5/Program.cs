internal class Program {
    private static void Main(string[] args) {

        // Entrada do texto
        Console.WriteLine("Digite o Texto: ");
        string texto = Console.ReadLine();

        // Invertendo a string. A cada iteração, i é decrementado em -1 até ler todo o texto.
        // no loop For pecorre a string de trás para frente que é guardado no "textoInvertido"
        string textoInvertido = "";
        for (int i = texto.Length - 1; i >= 0; i--) {
            textoInvertido += texto[i];
        }

        // Exibir a string invertida
        Console.WriteLine("Texto original: " + texto);
        Console.WriteLine("Texto invertido: " + textoInvertido);


    }
}