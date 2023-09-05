namespace Xurrasco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor_total,valor_total_carne, valor_total_bebida; // Declarando as variáveis para calcular o valor por pessoa
            
            Console.WriteLine("Calculadora churrasco.");

            Console.WriteLine("Digite quantas pessoas vão estar presentes:");   // Solicitando a quantidade de pessoas
            int quant_pessoa = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("Digite a quantidade de carne(R$ 50,00 kg):");    // Solicitando a quantidade de carne com um valor fixo
            int quant_carne = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a quantidade de bebidas(R$ 12,00):");     // Solicitando a quantidade de bebidas com um valor fixo
            int quant_bebida = int.Parse(Console.ReadLine()!);

            valor_total_carne = quant_carne * 50.00M;       // Fórmula para calcular o valor total das carnes

            valor_total_bebida = quant_bebida * 12.00M;     // Fórmula para calcular o valor total das bebidas

            valor_total = (valor_total_carne + valor_total_bebida) / quant_pessoa;  // Fórmula para calcular o valor total por pessoa

            Console.WriteLine($"Valor total para cada pessoa:{valor_total}");

        }
    }
}