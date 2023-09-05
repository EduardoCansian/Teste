
namespace Exercicio_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cadastro[] atendimento = new Cadastro[5];       // Atribuindo array no struct

            int opcao = 0;                           // Declaração das variáveis 

            Console.WriteLine("Bem vindo a fila de atendimento");
            while (opcao != 4)                  // Estrutura de repetição para retornar para o menu quando chegar ao fim de cada opção
            {
                Console.WriteLine("--------------Menu-------------");
                Console.WriteLine("1- Cadastro \n2- Listar fila \n3- Atendimento \n4- Sair");           // Menu com opções
                Console.Write("Escolha uma das opções:");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:                 // Opção para cadastrar a pessoa, o CPF e uma senha
                        Console.Clear();
                        CadastrarPessoa();
                        break;

                    case 2:                 // Opção para listar a pessoa, CPF e senha digitados pelo usuário
                        Console.Clear();
                        ListarFila();
                        break;

                    case 3:                 // Opção para realizar o atendimento e mostrar quem será a primeira pessoa a ser atendida 
                        Console.Clear();
                        Atender();
                        break;

                    case 4:                 // Opção para sair de menu
                        Console.Clear();
                        Sair();
                        break;
                    default:                // Opção para mostrar mensagem caso escreva uma opção inexistente
                        Console.Clear();
                        Console.WriteLine("Opção inválida, digite novamente");
                        break;
                }

            }

            void CadastrarPessoa()          // Função com as instruções e códigos para realizar o cadastro
            {
                
                for (int i = 0; i < atendimento.Length; i++)        // Estrutura de repetição pedindo nome, CPF e senha
                {

                    Console.WriteLine(">>>>>>Cadastro:<<<<<<");
                    Console.WriteLine("");
                    Console.Write($"Digite o {i+1}º nome:");
                    atendimento[i].nome = Console.ReadLine()!;
                    Console.Write("Digite o CPF:");
                    atendimento[i].cpf = int.Parse(Console.ReadLine()!);
                    Console.Write("Digite a senha:");
                    atendimento[i].senha = int.Parse(Console.ReadLine()!);
                    Console.Clear();

                }
                Console.WriteLine("Cadastro realizado com sucesso.");
                Console.Write("Presione qualquer tecla para retornar ao menu:");
                Console.ReadKey();
                Console.Clear();
            }

            void ListarFila()           // Função com instruções e códigos para listar as informações digitadas
            {
                Console.WriteLine("Lista:");
                Ordem();
                foreach (var fila in atendimento)       // Estrutura de repetição para exibir na tela as informações digitadas pelo usuário
                {
                    
                    Console.WriteLine("---------------------");
                    Console.WriteLine($"Nome:{fila.nome}");
                    Console.WriteLine($"CPF:{fila.cpf}");
                    Console.WriteLine($"Senha:{fila.senha}");
                    Console.WriteLine("");
                }
                Console.Write("Presione qualquer tecla para retornar ao menu:");
                Console.ReadKey();
                Console.Clear();
            }

            void Atender()          // Função para realizar o atendimento e exibir a primeira pessoa a ser atendida de acordo com a senha
            {
                Console.WriteLine("Atendimento:");
                Console.WriteLine("");
                
                for (int i = 0; i < 5; i++)     // Estrutura de repetição para imprimir na tela as informações na ordem digitadas
                {
                    Ordem();
                    Console.WriteLine($"{i + 1}º a ser atendido(a): \nNome: {atendimento[i].nome} \nCPF:{atendimento[i].cpf} \nSenha:{atendimento[i].senha}");
                    Console.Write("Presione qualquer tecla para confirmar atendimento dessa pessoa:");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Atendimento concluído.");
                Console.Write("Presione qualquer tecla para retornar ao menu:");
                Console.ReadKey();
                Console.Clear();
            }

            void Sair()         // Função para sair do programa
            {
                Console.WriteLine("Encerrando programa.");
                Console.WriteLine("Obrigado por utilizar nosso sistema :D");
            }

            void Ordem()        // Função responsável armazenar os dados digitados na ordem 
            {
                int aux = 0;
                string aux1;
                int aux2;
                for (int y = 0; y < 4; y++)
                {

                    for (int i = 0; i < 5 - 1; i++)
                    {
                        if (atendimento[i].senha > atendimento[i + 1].senha)        // Estrutura para calcular a ordem das informações digitadas
                        {

                            aux = atendimento[i + 1].senha;
                            aux1 = atendimento[i + 1].nome;
                            aux2 = atendimento[i + 1].cpf;
                            atendimento[i + 1].senha = atendimento[i].senha;
                            atendimento[i + 1].nome = atendimento[i].nome;
                            atendimento[i + 1].cpf = atendimento[i].cpf;

                            atendimento[i].senha = aux;
                            atendimento[i].nome = aux1;
                            atendimento[i].cpf = aux2;

                        }
                    }
                }
            }

        }

        public struct Cadastro          // Estrutura para armazenar várias variáveis
        {
            public string nome;
            public int cpf;
            public int senha;
        }

    }
}