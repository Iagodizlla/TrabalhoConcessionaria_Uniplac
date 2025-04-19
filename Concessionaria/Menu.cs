//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;
public class Menu
{
    public static void Cabecalho()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("        CONCESSIONARIA");
        Console.WriteLine("-----------------------------\n");
    }
    public static char MenuMotocicleta()
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
    public static char MenuCaminhonete()
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
    public static char MenuAutomovel()
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
    public static char MenuPrincipal()
    {
        Cabecalho();
        Console.WriteLine("1. Automovel");
        Console.WriteLine("2. Caminhonete");
        Console.WriteLine("3. Motocicleta");
        Console.WriteLine("S. Sair");
        Console.Write("Escolha uma opcao: ");
        char opcao = Console.ReadLine()!.ToUpper()[0];
        return opcao;
    }
}