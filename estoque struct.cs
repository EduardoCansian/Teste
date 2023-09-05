static void Main(string[] args)
{
    Estoque[] estoque = new Estoque[3];         // Atribuindo array no struct

    int opcao=0;

    Console.WriteLine("Bem vindo ao menu principal:");
    while (opcao != 3)          // Estrutura de repetição para retornar ao menu
    {

        Console.WriteLine (">>>>>>>Menu<<<<<<<");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("1- Cadastrar produtos \n2- Listar produtos \n3- Sair");  // Menu principal com opções
        Console.WriteLine("------------------------------------------------");
        Console.Write("Escolha uma das opções:");
        opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:         // Opção para cadastrar os produtos com nome, preço e código
                Console.Clear();
                CadastrarProduto();     // Chamando a função para cadastrar
                break;
            case 2:         // Opção para listar os produtos digitados pelo usuário
                Console.Clear();
                ListarProduto();        // Chamando a função para listar
                break;
            case 3:         // Opção para sair do estoque
                Console.Clear();
                Sair();     // Chamando a função para sair
                break;
        }
    }

    void CadastrarProduto()     // Função para cadastrar os produtos, preços e códigos
    {
        for (int i = 0; i < estoque.Length; i++)
        {

            Console.WriteLine($"Digite o {i + 1}º produto:");       // Solicitando o nome do produto
            estoque[i].produto = Console.ReadLine()!;

            Console.WriteLine($"Digite o preço do {i + 1}º produto:");      // Solicitando o preço deste produto
            estoque[i].preco = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o código do {i + 1}º produto:");     // Solicitando o código deste produto
            estoque[i].codigo = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("Presione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
    }

    void ListarProduto()        // Função para listar os produtos digitados pelo usuário
    {
        Console.WriteLine("Lista do estoque:");

        foreach (var item in estoque)
        {
            Console.WriteLine("------------------------");      
            Console.WriteLine($"Produto: {item.produto}");
            Console.WriteLine($"Preço: R${item.preco}");        
            Console.WriteLine($"Código: {item.codigo}");
            Console.WriteLine("------------------------");
        }
        Console.WriteLine("Presione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
    }

    void Sair()                 // Função para sair do estoque
    {
        Console.WriteLine("Programa encerrado");
        Console.WriteLine("Obrigado por utilizar nosso sistema :D");
    }
}



    public struct Estoque       // Estrutura para armazenar várias variáveis
    {
    public string produto;
    public decimal preco;
    public int codigo;


    }