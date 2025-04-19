using System.Net.Http.Headers;

namespace Concessionaria;

public class Program : Menu
{
    public static List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    public static void Main(string[] args)
    {
        while (true)
        {
            Cabecalho();
            char opcao = MenuPrincipal();
            bool sair = false;
            if (opcao == '3')
            {
                while (sair == false)
                {
                    Cabecalho();
                    char opcaoS = MenuMotocicleta();
                    switch (opcaoS)
                    {
                        case '1': CadastrarMotocicleta(); break;
                        case '2': EditarMotocicleta(); break;
                        case '3': RemoverMotocicleta(); break;
                        case '4': ListarMotocicleta(); break;
                        case 'S': sair = true; break;
                        default: Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar..."); break;
                    }
                }
            }
        }
    }
    public static void ListarMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Motocicleta");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -10} | {4, -10} | {5, -15}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco", "Cilindrada"
            );

        Motocicleta[] motocicletas = BuscarMotocicletas();
        if (motocicletas != null)
        {
            for (int i = 0; i < motocicletas.Length; i++)
            {
                if (motocicletas[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -10} | {4, -10} | {5, -15}",
                    motocicletas[i].Placa, motocicletas[i].Marca, motocicletas[i].Modelo, motocicletas[i].AnoFabricacao, motocicletas[i].Preco, motocicletas[i].Cilindrada
                );
            }
            Console.ReadLine();
        }
    }
    public static void EditarMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Editar Motocicleta");
        Console.WriteLine("------------------");

        ListarMotocicleta();
        Console.WriteLine("Digite a placa da motocicleta: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculoAntigo = BuscarVeiculo(placa);
        if(veiculoAntigo is Motocicleta)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Motocicleta");
            Console.WriteLine("---------------------");

            Motocicleta motocicleta = ObterDadosMotocicleta();
            AdicionarVeiculo(motocicleta);
        }
        else
        {
            Console.WriteLine("Motocicleta nao encontrada!");
            Console.ReadLine();
        }
    }
    public static Motocicleta ObterDadosMotocicleta()
    {
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricacao: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Combustivel: ");
        string combustivel = Console.ReadLine()!;
        Console.Write("Cambio: ");
        string cambio = Console.ReadLine()!;
        Console.Write("Capacidade do Tanque: ");
        double capacidadeTanque = double.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio: ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Preco: ");
        double preco = double.Parse(Console.ReadLine()!);
        Console.Write("Cilindrada: ");
        int cilindrada = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo (Street, Esportiva, Trail ou Custom): ");
        string tipo = Console.ReadLine()!;
        Console.Write("Partida (Eletrica ou Pedal): ");
        string partida = Console.ReadLine()!;

        string placa = anoFabricacao.ToString().Substring(0, 2) + marca.Substring(1, 1) + anoFabricacao.ToString().Substring(1, 1) + "-" +
            cor.Substring(0, 2) + modelo.Substring(0, 2);

        Motocicleta motocicleta = new Motocicleta(marca, modelo, anoFabricacao, cor, capacidadeOcupantes, combustivel, cambio,
            capacidadeTanque, tipoFreio, preco, cilindrada, tipo, partida, placa);
        return motocicleta;
    }
    public static void CadastrarMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Motocicleta");
        Console.WriteLine("---------------------");

        Motocicleta motocicleta = ObterDadosMotocicleta();
        AdicionarVeiculo(motocicleta);
    }
    public static void RemoverMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Motocicleta");
        Console.WriteLine("-------------------");

        ListarMotocicleta();
        Console.WriteLine("Digite a placa da motocicleta: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Motocicleta)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Motocicleta removida com sucesso!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Motocicleta nao encontrada!");
            Console.ReadLine();
        }
    }
    public static void AdicionarVeiculo(Veiculo veiculo)
    {
        Veiculos.Add(veiculo);
    }
    public static void RemoverVeiculo(Veiculo veiculo)
    {
        Veiculos.Remove(veiculo);
    }
    public static Motocicleta[] BuscarMotocicletas()
    {
        Motocicleta[] motocicletas = new Motocicleta[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadLine();
            return null!;
        }
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;
            if (Veiculos[i] is Motocicleta)
            {
                motocicletas[i] = (Motocicleta)Veiculos[i];
            }
        }
        return motocicletas;
    }
    public static Veiculo BuscarVeiculo(string placa)
    {
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i].Placa == placa)
            {
                return Veiculos[i];
            }
        }
        Console.WriteLine("Placa nao encontrada!");
        Console.ReadLine();
        return null!;
    }
}