//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// MenuNormal para o sistema de gerenciamento de veículos
public class Menu
{
    #region Principal
    public static void Cabecalho()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("  GERENCIAR CONCESSIONARIA");
        Console.WriteLine("-----------------------------\n");
    }
    public static char MenuPrincipal()
    {
        Cabecalho();
        Console.WriteLine("1. Veiculo de Passageiro");
        Console.WriteLine("2. Veiculo de Carga");
        Console.WriteLine("3. Veiculo Misto");
        Console.WriteLine("4. Lsitar Veiculos");
        Console.WriteLine("S. Voltar");
        Console.Write("Escolha uma opcao: ");
        char opcao = Console.ReadLine()!.ToUpper()[0];
        return opcao;
    }
    public static char MenuNormal()
    {
        Cabecalho();
        Console.WriteLine("1. Cadastrar");
        Console.WriteLine("2. Editar");
        Console.WriteLine("3. Remover");
        Console.WriteLine("4. Listar");
        Console.WriteLine("S. Voltar");
        Console.Write("Escolha uma opcao: ");
        char opcao = Console.ReadLine()!.ToUpper()[0];
        return opcao;
    }
    #endregion
    #region Classes intermediarias
    public static char MenuSegundarioPassageiro()
    {
        Cabecalho();
        Console.WriteLine("1. Automovel");
        Console.WriteLine("2. Bicicleta");
        Console.WriteLine("3. Motocicleta");
        Console.WriteLine("S. Sair");
        Console.Write("Escolha uma opcao: ");
        char opcao = Console.ReadLine()!.ToUpper()[0];
        return opcao;
    }
    public static char MenuSegundarioCarga()
    {
        Cabecalho();
        Console.WriteLine("1. Caminhonete");
        Console.WriteLine("2. Caminhao");
        Console.WriteLine("S. Sair");
        Console.Write("Escolha uma opcao: ");
        char opcao = Console.ReadLine()!.ToUpper()[0];
        return opcao;
    }
    #endregion
}