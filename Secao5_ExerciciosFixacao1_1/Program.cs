
using System.Globalization;
using Secao5_ExerciciosFixacao1_1;

    class Program
{
        static void Main(string[] args)
    {
        ContaBancaria conta;

        Console.Write("Registre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)?: ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Digite o valor do depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = new ContaBancaria(numero, titular, depositoInicial);
        } else
        {
            conta = new ContaBancaria(numero, titular);
        }
        Console.WriteLine();
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(conta.ToString());
        Console.WriteLine();
        
        Console.Write("Digite o valor do depósito:");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Digite o valor do saque:");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(conta);
    }
}