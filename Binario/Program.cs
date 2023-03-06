internal class Program
{
    private static void Main(string[] args)
    {
        int ninformado;
        int[] binario = new int[8];
        int temp, posicao;
        int resto = 0;

        Console.Write("Informe um número: ");
        ninformado = int.Parse(Console.ReadLine());

        temp = ninformado;

        for (int i = 0; i < binario.Length; i++)
        {
            resto = temp % 2;
            binario[i] = resto;
            temp = ninformado / 2;
            ninformado = temp;

        }
        for (int i = binario.Length - 1; i >= 0; i--)
        {
            Console.Write(binario[i]);
        }

    }
}
