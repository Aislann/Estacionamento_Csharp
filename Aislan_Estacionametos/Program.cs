// Declarando variáveis
using Aislan_Estacionametos;

decimal precoInicial = 0;
decimal precoHora = 0;

//Iniciar o sistema
Console.WriteLine("Sejam bem vindos à Aislan Estacionamentos\n" +
                  "-----------------------------------------");
Console.WriteLine("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

//Instancia a classe Estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoHora);

//Loop

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("1- Adicionar Veiculo\n" +
        "2- Remover Veiculo\n" +
        "3- Listar Veiculo\n" +
        "0- Sair do Sistema\n" +
        "Escolha uma opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            es.adcionarVeiculo();
            break;
            case "2":
                es.removerVeiculo(); 
            break;
            case "3":   
            es.listarVeiculo();
            break;
            case "4":
            menu = false;
            break;

            default: 
            Console.WriteLine("Digite uma opção válida");
            break;
    }

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa encerrou! ");