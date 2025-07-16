/**
 * Escrever um código que possua um saldo inicial de uma conta e ofereça, 
   através de um menu exibido no console, as seguintes opções para o usuário:

- Exibir saldo: exibe o saldo atual no console
- Depositar: solicita um valor (double) ao usuário e acresce ao saldo
- Sacar: solicita um valor (double) ao usuário e decresce do saldo
- Extrato: exibe as transações que foram realizadas, separadas por vírgula
- Sair: termina a execução do programa
*/

double saldo = 0;
int opcao;

do
{
    ExibirMenu();

    if (int.TryParse(Console.ReadLine(), out opcao))
    {
        switch (opcao)
        {
            case 1:
                ExibirSaldo();
                Console.ReadKey();
                break;
            case 2:
                Depositar();
                Console.ReadKey();
                break;
            case 3:
                
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Extrato");
                Console.ReadKey();
                break;
            case 5:
                Console.WriteLine("Sair");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Escolha uma opção válida.");
                break;
        }
    }
    else
    {
        // Não conseguiu converter
        Console.WriteLine($"Não é uma opção válida. Tente novamente.");
        Console.ReadKey();
    }

} while (opcao != 5);

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("Selecione uma das opções abaixo:");
    Console.WriteLine("1 - Saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Extrato");
    Console.WriteLine("5 - Sair");
}

void ExibirSaldo()
{
    if (saldo < 0 )
    {

    Console.WriteLine($"Saldo atual >R$ {saldo } 😰")
    } else{

    Console.WriteLine($"Saldo atual > R$ {saldo} 💵");
    }


}

void Depositar()
{
    double deposito;

    if (double.TryParse(Console.ReadLine(), out deposito))
    {
        saldo = saldo + deposito;
    }
    else
    {
        Console.WriteLine("Valor para depósito inválido.");
    }
}

void Sacar()
{

    double saque;

  if( double.TryParse(Console.ReadLine(), out saque))
{
    saldo = saldo - saque

}
}

void Extrato()

{


string caminho = "extrato.txt" ; // caminho do arquivo a ser lido/ escrito 
    string conteudo = File.ReadAllText(caminho); // lê o conteudo de arquivo 

    
    string[] transacoes = conteudo.Split("\",""\");
    for(int cont = 0; cont < transacoes[cont]){
        Console.WriteLine();
    }
}



void SalvarDeposito(double paramDeposito){


    string caminho = "extrato.txt" ; // caminho do arquivo a ser lido/ escrito 
    string conteudo = File.ReadAllText(caminho); // lê o conteudo de arquivo 

    //escreve o conteudo no arquivo, concatenando com o conteudo atual
    File.WriteAllText(caminho + "\"saque: "" Este texto foi saçvo atravez do c-sharp\",");


}

void SalvarSaque (double paramSaque){



}


