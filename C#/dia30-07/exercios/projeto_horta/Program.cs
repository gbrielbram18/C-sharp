// Invocação do método ExibirMenu
ExibirMenu();

// Atribuindo à variável opcao o retorno do método Console.ReadLine(), que é uma string
int opcao = int.Parse(Console.ReadLine()); // Console.ReadLine() captura e retorna uma string fornecida pelo usuário

// Verifica o valor da variável opcao
switch (opcao)
{
    case 1:
        // Opção fruta selecionada
        Console.WriteLine("Digite o nome da fruta a ser salva:");
        string fruta = Console.ReadLine(); // Atribuição do retorno do método Console.Readline() à variável fruta

        string arquivo = "dados/frutas.csv";
        string conteudoAtual = File.ReadAllText(arquivo); // Lê o conteúdo atual do arquivo

        string[] frutasExistentes = conteudoAtual.Split(",");
        bool frutaJaExiste = false;

        for (int count = 0; count < frutasExistentes.Length; count++)
        {
            if (fruta == frutasExistentes[count])
            {
                frutaJaExiste = true;
                Console.WriteLine("Fruta já existe.");
            }
        }

        if (frutaJaExiste == false)
        {
            Console.WriteLine("Fruta não existe ainda, salvando no nosso banco de dados...");
            File.WriteAllText(arquivo, conteudoAtual + fruta + ","); // Salva conteúdo no arquivo especificado
        }
        break;
    case 2:
        // Opção legume selecionada
        break;
    case 3:
        // Opção verdura selecionada
        break;
    default:
        // Nenhuma das opções previstas foi selecionada
        break;
}

// Declaração do método ExibirMenu
void ExibirMenu()
{
    Console.WriteLine("Que tipo de produto você gostaria de cadastrar?");
    Console.WriteLine("1 - Fruta");
    Console.WriteLine("2 - Legume");
    Console.WriteLine("3 - Verdura");
}