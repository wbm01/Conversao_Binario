internal class Program
{
    private static void Main(string[] args)
    {

        int resultado;

        int binario(int numero)
        {
            if (numero == 0)
                return 0;
            else
                return (numero % 2 + 10 * binario(numero / 2));
        }

        Console.WriteLine("Informe o número: ");
        resultado = int.Parse(Console.ReadLine());

        Console.WriteLine(binario(resultado));
    }
}

