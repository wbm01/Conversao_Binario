internal class Program
{
    private static void Main(string[] args)
    {

        int[] binario = new int[8];
        int[] convertido = new int[8];
        int valor, resto, quociente;

        Console.WriteLine("Informe um número para versão em binário: ");
        valor = int.Parse(Console.ReadLine());
        convertido = converter(valor);


        int[] converter(int valor)
        {
            quociente = valor;

            for (int contador = 0; contador < binario.Length; contador++)
            {
                resto = quociente % 2;
                binario[contador] = resto;
                quociente = valor / 2;
                valor = quociente;
            }
            return binario;
        }

        for(int contador = binario.Length-1 ;contador >= 0; contador--)
        {
            Console.Write(binario[contador] + " ");
            
        }

    }
}
