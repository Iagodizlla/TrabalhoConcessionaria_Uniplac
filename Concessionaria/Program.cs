//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;
public class Program
{
    public static List<Veiculo> Veiculos = new List<Veiculo>();

    public static void Main(string[] args)
    {
        Revenda revenda = CadastrarRevenda();
        while (true)
        {
            Menu.Cabecalho();
            char opcao = Menu.MenuPrincipal();
            bool sair = false;
            if (opcao == '1')
            {
                while (sair == false)
                {
                    Menu.Cabecalho();
                    char opcaoS = Menu.MenuSegundarioPassageiro();
                    switch (opcaoS)
                    {
                        case '1':
                            while (sair == false)
                            {
                                opcao = Menu.MenuNormal();
                                if (opcao == '1')
                                    CadastrarAutomovel();
                                else if (opcao == '2')
                                    EditarAutomovel();
                                else if (opcao == '3')
                                    RemoverAutomovel();
                                else if (opcao == '4')
                                    ListarAutomovel();
                                else if (opcao == 'S')
                                    sair = true;
                                else
                                {
                                    Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            sair = false;
                            break;
                        case '2':
                            while (sair == false)
                            {
                                opcao = Menu.MenuNormal();
                                if (opcao == '1')
                                    CadastrarBicicleta();
                                else if (opcao == '2')
                                    EditarBicicleta();
                                else if (opcao == '3')
                                    RemoverBicicleta();
                                else if (opcao == '4')
                                    ListarBicicleta();
                                else if (opcao == 'S')
                                    sair = true;
                                else
                                {
                                    Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            sair = false;
                            break;
                        case '3':
                            while (sair == false)
                            {
                                opcao = Menu.MenuNormal();
                                if (opcao == '1')
                                    CadastrarMotocicleta();
                                else if (opcao == '2')
                                    EditarMotocicleta();
                                else if (opcao == '3')
                                    RemoverMotocicleta();
                                else if (opcao == '4')
                                    ListarMotocicleta();
                                else if (opcao == 'S')
                                    sair = true;
                                else
                                {
                                    Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            sair = false;
                            break;
                        case 'S': sair = true; break;
                        default: Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar..."); Console.ReadKey(); break;
                    }
                }
            }
            else if (opcao == '2')
            {
                while (sair == false)
                {
                    Menu.Cabecalho();
                    char opcaoS = Menu.MenuSegundarioCarga();
                    switch (opcaoS)
                    {
                        case '1':
                            while (sair == false)
                            {
                                opcao = Menu.MenuNormal();
                                if (opcao == '1')
                                    CadastrarCaminhonete();
                                else if (opcao == '2')
                                    EditarCaminhonete();
                                else if (opcao == '3')
                                    RemoverCaminhonete();
                                else if (opcao == '4')
                                    ListarCaminhonete();
                                else if (opcao == 'S')
                                    sair = true;
                                else
                                {
                                    Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            sair = false;
                            break;
                        case '2':
                            while (sair == false)
                            {
                                opcao = Menu.MenuNormal();
                                if (opcao == '1')
                                    CadastrarCaminhao();
                                else if (opcao == '2')
                                    EditarCaminhao();
                                else if (opcao == '3')
                                    RemoverCaminhao();
                                else if (opcao == '4')
                                    ListarCaminhao();
                                else if (opcao == 'S')
                                    sair = true;
                                else
                                {
                                    Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                            sair = false;
                            break;
                        case 'S': sair = true; break;
                        default: Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar..."); Console.ReadKey(); break;
                    }
                }
            }
            else if (opcao == '3')
            {
                while (sair == false)
                {
                    Menu.Cabecalho();
                    char opcaoS = Menu.MenuNormal();
                    switch (opcaoS)
                    {
                        case '1': CadastrarUtilitario(); break;
                        case '2': EditarUtilitario(); break;
                        case '3': RemoverUtilitario(); break;
                        case '4': ListarUtilitario(); break;
                        case 'S': sair = true; break;
                        default: Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar..."); Console.ReadKey(); break;
                    }
                }
            }
            else if (opcao == '4')
            {
                ListarVeiculos();
            }
            else if (opcao == '5')
            {
                MostrarDadosRevenda(revenda);
            }
            else if (opcao == 'S')
            {
                break;
            }
            else
            {
                Console.WriteLine("Opcao invalida! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
    #region Automovel
    public static void CadastrarAutomovel()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Automovel");
        Console.WriteLine("---------------------");

        Automovel automovel = ObterDadosAutomovel(false, "");
        AdicionarVeiculo(automovel);
    }
    public static Automovel ObterDadosAutomovel(bool editar, string placa)
    {
        if (editar == false)
        {
            Console.Write("Placa: ");
            placa = Console.ReadLine()!.ToUpper();
        }
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricação: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio (Disco, Tambor, ABS): ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Câmbio (manual/automático): ");
        string cambio = Console.ReadLine()!;
        Console.Write("Tamanho do Aro: ");
        int tamanhoAro = int.Parse(Console.ReadLine()!);
        Console.Write("Número de Portas: ");
        int numeroPortas = int.Parse(Console.ReadLine()!);
        Console.Write("Capacidade do Tanque (L): ");
        double capacidadeTanque = double.Parse(Console.ReadLine()!);
        Console.Write("Ar Condicionado (true/false): ");
        bool arCondicionado = bool.Parse(Console.ReadLine()!);
        Console.Write("Airbags (true/false): ");
        bool airbags = bool.Parse(Console.ReadLine()!);
        Console.Write("Sistema de Som (true/false): ");
        bool sistemaSom = bool.Parse(Console.ReadLine()!);
        Console.Write("Estepe (true/false): ");
        bool estepe = bool.Parse(Console.ReadLine()!);
        Console.Write("Carroceria (Hatch/Sedan/SUV): ");
        string carroceria = Console.ReadLine()!;

        Automovel automovel = new Automovel(
            preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes,
            tipoFreio, cambio, placa, tamanhoAro, numeroPortas, capacidadeTanque,
            arCondicionado, airbags, sistemaSom, estepe, carroceria
        );
        return automovel;
    }
    public static void ListarAutomovel()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Automovel");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco", "Numero de portas"
            );

        Automovel[] automoveis = BuscarAutomoveis();
        if (automoveis != null)
        {
            for (int i = 0; i < automoveis.Length; i++)
            {
                if (automoveis[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
                    automoveis[i].Placa, automoveis[i].Marca, automoveis[i].Modelo, automoveis[i].AnoFabricacao, automoveis[i].Preco, automoveis[i].NumeroPortas
                );
            }
            Console.ReadKey();
        }
    }
    public static Automovel[] BuscarAutomoveis()
    {
        Automovel[] automoveis = new Automovel[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadLine();
            return null!;
        }
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;
            if (Veiculos[i] is Automovel)
            {
                automoveis[i] = (Automovel)Veiculos[i];
            }
        }
        return automoveis;
    }
    public static void RemoverAutomovel()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Automovel");
        Console.WriteLine("-------------------");

        ListarAutomovel();
        Console.WriteLine("Digite a placa da automovel: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Automovel)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Automovel removida com sucesso!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Automovel nao encontrada!");
            Console.ReadKey();
        }
    }
    public static void EditarAutomovel()
    {
        Menu.Cabecalho();
        Console.WriteLine("Editar Automovel");
        Console.WriteLine("------------------");

        ListarAutomovel();
        Console.WriteLine("Digite a placa da automovel: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculoAntigo = BuscarVeiculo(placa);
        if (veiculoAntigo is Automovel)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Automovel");
            Console.WriteLine("---------------------");

            Automovel automovel = ObterDadosAutomovel(true, placa);
            AdicionarVeiculo(automovel);
        }
        else
        {
            Console.WriteLine("Automovel nao encontrada!");
            Console.ReadKey();
        }
    }
    #endregion
    #region Bicicleta
    public static void CadastrarBicicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Bicicleta");
        Console.WriteLine("---------------------");

        Bicicleta bicicleta = ObterDadosBicicleta(false, "");
        AdicionarVeiculo(bicicleta);
    }
    public static Bicicleta ObterDadosBicicleta(bool editar, string placa)
    {
        if (editar == false)
        {
            Console.Write("Placa: ");
            placa = Console.ReadLine()!.ToUpper();
        }
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricação: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio (Disco, Tambor): ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Câmbio (manual/automático): ");
        string cambio = Console.ReadLine()!;
        Console.Write("Tamanho do Aro: ");
        int tamanhoAro = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo (Mountain/BMX/Cross): ");
        string tipo = Console.ReadLine()!;
        Console.Write("Dobrável (true/false): ");
        bool dobravela = bool.Parse(Console.ReadLine()!);

        Bicicleta bicicleta = new Bicicleta(
            preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes,
            tipoFreio, cambio, placa, tamanhoAro, tipo, dobravela
        );
        return bicicleta;
    }
    public static void ListarBicicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Bicicleta");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco", "Tipo"
            );

        Bicicleta[] bicicletas = BuscarBicicletas();
        if (bicicletas != null)
        {
            for (int i = 0; i < bicicletas.Length; i++)
            {
                if (bicicletas[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
                    bicicletas[i].Placa, bicicletas[i].Marca, bicicletas[i].Modelo, bicicletas[i].AnoFabricacao, bicicletas[i].Preco, bicicletas[i].Tipo
                );
            }
            Console.ReadKey();
        }
    }
    public static Bicicleta[] BuscarBicicletas()
    {
        Bicicleta[] bicicletas = new Bicicleta[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadKey();
            return null!;
        }
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;
            if (Veiculos[i] is Bicicleta)
            {
                bicicletas[i] = (Bicicleta)Veiculos[i];
            }
        }
        return bicicletas;
    }
    public static void RemoverBicicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Bicicleta");
        Console.WriteLine("-------------------");

        ListarBicicleta();
        Console.WriteLine("Digite a placa da bicicleta: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Bicicleta)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Bicicleta removida com sucesso!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Bicicleta nao encontrada!");
            Console.ReadKey();
        }
    }
    public static void EditarBicicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Editar Bicicleta");
        Console.WriteLine("------------------");

        ListarBicicleta();
        Console.WriteLine("Digite a placa da bicicleta: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculoAntigo = BuscarVeiculo(placa);
        if (veiculoAntigo is Bicicleta)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Bicicleta");
            Console.WriteLine("---------------------");

            Bicicleta bicicleta = ObterDadosBicicleta(true, placa);
            AdicionarVeiculo(bicicleta);
        }
        else
        {
            Console.WriteLine("Bicicleta nao encontrada!");
            Console.ReadKey();
        }
    }
    #endregion
    #region Caminhonete
    public static void CadastrarCaminhonete()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Caminhonete");
        Console.WriteLine("---------------------");

        Caminhonete caminhonete = ObterDadosCaminhonete(false, "");
        AdicionarVeiculo(caminhonete);
    }
    public static Caminhonete ObterDadosCaminhonete(bool editar, string placa)
    {
        if (editar == false)
        {
            Console.Write("Placa: ");
            placa = Console.ReadLine()!.ToUpper();
        }
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricação: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio: ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Câmbio: ");
        string cambio = Console.ReadLine()!;
        Console.Write("Capacidade de Carga (em kg): ");
        int capacidadeCarga = int.Parse(Console.ReadLine()!);
        Console.Write("Potência do Motor (em cv): ");
        int potenciaMotor = int.Parse(Console.ReadLine()!);
        Console.Write("Tração (4x2/4x4): ");
        string tracao = Console.ReadLine()!;
        Console.Write("Número de Portas: ");
        int numeroPortas = int.Parse(Console.ReadLine()!);
        Console.Write("Capacidade do Tanque (L): ");
        double capacidadeTanque = double.Parse(Console.ReadLine()!);
        Console.Write("Ar Condicionado (true/false): ");
        bool arCondicionado = bool.Parse(Console.ReadLine()!);
        Console.Write("Airbags (true/false): ");
        bool airbags = bool.Parse(Console.ReadLine()!);
        Console.Write("Estepe (true/false): ");
        bool estepe = bool.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Carroceria (aberta/fechada): ");
        string tipoCarroceria = Console.ReadLine()!;
        Console.Write("Engate Reboque (true/false): ");
        bool engateReboque = bool.Parse(Console.ReadLine()!);

        Caminhonete caminhonete = new Caminhonete(
            preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes,
            tipoFreio, cambio, placa, capacidadeCarga, potenciaMotor, tracao,
            numeroPortas, capacidadeTanque, arCondicionado, airbags, estepe,
            tipoCarroceria, engateReboque
        );
        return caminhonete;
    }
    public static void ListarCaminhonete()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Caminhonete");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco", "Capacidade de Carga"
            );

        Caminhonete[] caminhonetes = BuscarCaminhonetes();
        if (caminhonetes != null)
        {
            for (int i = 0; i < caminhonetes.Length; i++)
            {
                if (caminhonetes[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
                    caminhonetes[i].Placa, caminhonetes[i].Marca, caminhonetes[i].Modelo, caminhonetes[i].AnoFabricacao, caminhonetes[i].Preco, caminhonetes[i].CapacidadeCarga
                );
            }
            Console.ReadKey();
        }
    }
    public static Caminhonete[] BuscarCaminhonetes()
    {
        Caminhonete[] caminhonetes = new Caminhonete[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadLine();
            return null!;
        }
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;
            if (Veiculos[i] is Caminhonete)
            {
                caminhonetes[i] = (Caminhonete)Veiculos[i];
            }
        }
        return caminhonetes;
    }
    public static void RemoverCaminhonete()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Caminhonete");
        Console.WriteLine("-------------------");

        ListarCaminhonete();
        Console.WriteLine("Digite a placa da automovel: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Caminhonete)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Caminhonete removida com sucesso!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Caminhonete nao encontrada!");
            Console.ReadKey();
        }
    }
    public static void EditarCaminhonete()
    {
        Menu.Cabecalho();
        Console.WriteLine("Editar Caminhonete");
        Console.WriteLine("------------------");

        ListarCaminhonete();
        Console.WriteLine("Digite a placa da caminhonete: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculoAntigo = BuscarVeiculo(placa);
        if (veiculoAntigo is Caminhonete)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Caminhonete");
            Console.WriteLine("---------------------");

            Caminhonete caminhonete = ObterDadosCaminhonete(true, placa);
            AdicionarVeiculo(caminhonete);
        }
        else
        {
            Console.WriteLine("Caminhonete nao encontrada!");
            Console.ReadKey();
        }
    }
    #endregion
    #region Caminhao
    public static void CadastrarCaminhao()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Caminhao");
        Console.WriteLine("---------------------");

        Caminhao caminhao = ObterDadosCaminhao(false, "");
        AdicionarVeiculo(caminhao);
    }
    public static Caminhao ObterDadosCaminhao(bool editar, string placa)
    {
        if (editar == false)
        {
            Console.Write("Placa: ");
            placa = Console.ReadLine()!.ToUpper();
        }
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricação: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio: ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Câmbio: ");
        string cambio = Console.ReadLine()!;
        Console.Write("Capacidade de Carga (em kg): ");
        int capacidadeCarga = int.Parse(Console.ReadLine()!);
        Console.Write("Potência do Motor (em cv): ");
        int potenciaMotor = int.Parse(Console.ReadLine()!);
        Console.Write("Tração (4x2/4x4): ");
        string tracao = Console.ReadLine()!;
        Console.Write("Número de Portas: ");
        int numeroPortas = int.Parse(Console.ReadLine()!);
        Console.Write("Número de Eixos: ");
        int numeroEixos = int.Parse(Console.ReadLine()!);
        Console.Write("Capacidade do Tanque (L): ");
        double capacidadeTanque = double.Parse(Console.ReadLine()!);
        Console.Write("Ar Condicionado (true/false): ");
        bool arCondicionado = bool.Parse(Console.ReadLine()!);
        Console.Write("Airbags (true/false): ");
        bool airbags = bool.Parse(Console.ReadLine()!);
        Console.Write("Estepe (true/false): ");
        bool estepe = bool.Parse(Console.ReadLine()!);

        Caminhao caminhao = new Caminhao(
            preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes,
            tipoFreio, cambio, placa, capacidadeCarga, potenciaMotor, tracao,
            numeroPortas, capacidadeTanque, arCondicionado, airbags, estepe, numeroEixos
            );

        return caminhao;
    }
    public static void ListarCaminhao()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Caminhao");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco", "Numero de Eixos"
            );

        Caminhao[] caminhoes = BuscarCaminhoes();
        if (caminhoes != null)
        {
            for (int i = 0; i < caminhoes.Length; i++)
            {
                if (caminhoes[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
                    caminhoes[i].Placa, caminhoes[i].Marca, caminhoes[i].Modelo, caminhoes[i].AnoFabricacao, caminhoes[i].Preco, caminhoes[i].NumeroEixos
                );
            }
            Console.ReadKey();
        }
    }
    public static Caminhao[] BuscarCaminhoes()
    {
        Caminhao[] caminhoes = new Caminhao[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadKey();
            return null!;
        }
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;
            if (Veiculos[i] is Caminhao)
            {
                caminhoes[i] = (Caminhao)Veiculos[i];
            }
        }
        return caminhoes;
    }
    public static void RemoverCaminhao()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Caminhao");
        Console.WriteLine("-------------------");

        ListarCaminhao();
        Console.WriteLine("Digite a placa do caminhao: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Caminhao)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Caminhao removido com sucesso!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Caminhao nao encontrado!");
            Console.ReadKey();
        }
    }
    public static void EditarCaminhao()
    {
        Menu.Cabecalho();
        Console.WriteLine("Editar Caminhao");
        Console.WriteLine("------------------");

        ListarCaminhao();
        Console.WriteLine("Digite a placa do caminhao: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculoAntigo = BuscarVeiculo(placa);
        if (veiculoAntigo is Caminhao)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Caminhao");
            Console.WriteLine("---------------------");

            Caminhao caminhao = ObterDadosCaminhao(true, placa);
            AdicionarVeiculo(caminhao);
        }
        else
        {
            Console.WriteLine("Caminhao nao encontrado!");
            Console.ReadKey();
        }
    }
    #endregion
    #region Motocicleta
    public static void ListarMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Motocicleta");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco", "Cilindrada"
            );

        Motocicleta[] motocicletas = BuscarMotocicletas();
        if (motocicletas != null)
        {
            for (int i = 0; i < motocicletas.Length; i++)
            {
                if (motocicletas[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10} | {5, -15}",
                    motocicletas[i].Placa, motocicletas[i].Marca, motocicletas[i].Modelo, motocicletas[i].AnoFabricacao, motocicletas[i].Preco, motocicletas[i].Cilindrada
                );
            }
            Console.ReadKey();
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
        if (veiculoAntigo is Motocicleta)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Motocicleta");
            Console.WriteLine("---------------------");

            Motocicleta motocicleta = ObterDadosMotocicleta(true, placa);
            AdicionarVeiculo(motocicleta);
        }
        else
        {
            Console.WriteLine("Motocicleta nao encontrada!");
            Console.ReadKey();
        }
    }
    public static Motocicleta ObterDadosMotocicleta(bool editar, string placa)
    {
        if (editar == false)
        {
            Console.Write("Placa: ");
            placa = Console.ReadLine()!.ToUpper();
        }
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricação: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio (Disco, Tambor, ABS): ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Câmbio (manual/automático): ");
        string cambio = Console.ReadLine()!;
        Console.Write("Tamanho do Aro (em polegadas): ");
        int tamanhoAro = int.Parse(Console.ReadLine()!);
        Console.Write("Cilindrada (ex: 150, 600): ");
        int cilindrada = int.Parse(Console.ReadLine()!);
        Console.Write("Capacidade do Tanque (em litros): ");
        double capacidadeTanque = double.Parse(Console.ReadLine()!);
        Console.Write("Tipo (Street, Esportiva, Trail ou Custom): ");
        string tipo = Console.ReadLine()!;
        Console.Write("Partida (Elétrica ou Pedal): ");
        string partida = Console.ReadLine()!;
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);
        Motocicleta motocicleta = new Motocicleta(
            preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes,
            tipoFreio, cambio, placa, tamanhoAro, cilindrada, capacidadeTanque,
            tipo, partida
        );
        return motocicleta;
    }
    public static Motocicleta[] BuscarMotocicletas()
    {
        Motocicleta[] motocicletas = new Motocicleta[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadKey();
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
    public static void CadastrarMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Motocicleta");
        Console.WriteLine("---------------------");

        Motocicleta motocicleta = ObterDadosMotocicleta(false, "");
        AdicionarVeiculo(motocicleta);
    }
    public static void RemoverMotocicleta()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Motocicleta");
        Console.WriteLine("-------------------");

        ListarMotocicleta();
        Console.WriteLine("Digite a placa da automovel: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Motocicleta)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Motocicleta removida com sucesso!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Motocicleta nao encontrada!");
            Console.ReadKey();
        }
    }
    #endregion
    #region Utilitario
    public static void CadastrarUtilitario()
    {
        Menu.Cabecalho();
        Console.WriteLine("Cadastrar Utilitario");
        Console.WriteLine("---------------------");

        Utilitario utilitario = ObterDadosUtilitario(false, "");
        AdicionarVeiculo(utilitario);
    }
    public static void RemoverUtilitario()
    {
        Menu.Cabecalho();
        Console.WriteLine("Remover Utilitario");
        Console.WriteLine("-------------------");

        ListarUtilitario();
        Console.WriteLine("Digite a placa do utilitario: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculo = BuscarVeiculo(placa);
        if (veiculo is Utilitario)
        {
            RemoverVeiculo(veiculo);
            Console.WriteLine("Utilitario removido com sucesso!");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Utilitario nao encontrado!");
            Console.ReadKey();
        }
    }
    public static void EditarUtilitario()
    {
        Menu.Cabecalho();
        Console.WriteLine("Editar Utilitario");
        Console.WriteLine("------------------");

        ListarUtilitario();
        Console.WriteLine("Digite a placa do utilitario: ");
        string placa = Console.ReadLine()!;
        Veiculo veiculoAntigo = BuscarVeiculo(placa);
        if (veiculoAntigo is Utilitario)
        {
            RemoverVeiculo(veiculoAntigo);
            Menu.Cabecalho();
            Console.WriteLine("Editar Utilitario");
            Console.WriteLine("---------------------");

            Utilitario utilitario = ObterDadosUtilitario(true, placa);
            AdicionarVeiculo(utilitario);
        }
        else
        {
            Console.WriteLine("Utilitario nao encontrado!");
            Console.ReadKey();
        }
    }
    public static Utilitario ObterDadosUtilitario(bool editar, string placa)
    {
        if (editar == false)
        {
            Console.Write("Placa: ");
            placa = Console.ReadLine()!.ToUpper();
        }
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine()!);
        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano de Fabricação: ");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.Write("Cor: ");
        string cor = Console.ReadLine()!;
        Console.Write("Capacidade de Ocupantes: ");
        int capacidadeOcupantes = int.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Freio: ");
        string tipoFreio = Console.ReadLine()!;
        Console.Write("Câmbio: ");
        string cambio = Console.ReadLine()!;
        Console.Write("Tipo Misto (Sim/Não): ");
        string tipoMisto = Console.ReadLine()!;
        Console.Write("Número de Portas: ");
        int numeroPortas = int.Parse(Console.ReadLine()!);
        Console.Write("Capacidade do Tanque (L): ");
        double capacidadeTanque = double.Parse(Console.ReadLine()!);
        Console.Write("Ar Condicionado (true/false): ");
        bool arCondicionado = bool.Parse(Console.ReadLine()!);
        Console.Write("Airbags (true/false): ");
        bool airbags = bool.Parse(Console.ReadLine()!);
        Console.Write("Estepe (true/false): ");
        bool estepe = bool.Parse(Console.ReadLine()!);
        Console.Write("Tipo de Utilitário (Picape/SUV): ");
        string tipoUtilitario = Console.ReadLine()!;
        Console.Write("Engate Reboque (true/false): ");
        bool engateReboque = bool.Parse(Console.ReadLine()!);

        Utilitario utilitario = new Utilitario(
            preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes,
            tipoFreio, cambio, placa, tipoMisto, numeroPortas, capacidadeTanque,
            arCondicionado, airbags, estepe, tipoUtilitario, engateReboque
            );
        return utilitario;
    }
    public static void ListarUtilitario()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Utilitario");
        Console.WriteLine("------------------");
        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10}",
            "Placa", "Marca", "Modelo", "Ano Fabricacao", "Preco"
            );

        Utilitario[] utilitarios = BuscarUtilitarios();
        if (utilitarios != null)
        {
            for (int i = 0; i < utilitarios.Length; i++)
            {
                if (utilitarios[i] == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -20} | {3, -15} | {4, -10}",
                    utilitarios[i].Placa, utilitarios[i].Marca, utilitarios[i].Modelo, utilitarios[i].AnoFabricacao, utilitarios[i].Preco
                );
            }
            Console.ReadKey();
        }
    }
    public static Utilitario[] BuscarUtilitarios()
    {
        Utilitario[] utilitarios = new Utilitario[Veiculos.Count];
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nao existe veiculos.");
            Console.ReadKey();
            return null!;
        }
        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;
            if (Veiculos[i] is Utilitario)
            {
                utilitarios[i] = (Utilitario)Veiculos[i];
            }
        }
        return utilitarios;
    }
    #endregion
    #region Veiculo
    public static void RemoverVeiculo(Veiculo veiculo)
    {
        Veiculos.Remove(veiculo);
    }
    public static void AdicionarVeiculo(Veiculo veiculo)
    {
        Veiculos.Add(veiculo);
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
        return null!;
    }
    public static void ListarVeiculos()
    {
        Menu.Cabecalho();
        Console.WriteLine("Listar Veiculos");
        Console.WriteLine("------------------");

        for (int i = 0; i < Veiculos.Count; i++)
        {
            if (Veiculos[i] == null) continue;

            Veiculo veiculo = Veiculos[i];
            Veiculo automovel = new Automovel(preco: 0, marca: null!, modelo: null!, anoFabricacao: 0, cor: null!, capacidadeOcupantes: 0,
                tipoFreio: null!, cambio: null!, placa: null!, tamanhoAro: 0, numeroPortas: 0, capacidadeTanque: 0.0, arCondicionado: false,
                airbags: false, sistemaSom: false, estepe: false, carroceria: null!);

            Veiculo caminhonete = new Caminhonete(preco: 0, marca: null!, modelo: null!, anoFabricacao: 0, cor: null!, capacidadeOcupantes: 0,
                tipoFreio: null!, cambio: null!, placa: null!, capacidadeCarga: 0, potenciaMotor: 0, tracao: null!, numeroPortas: 0,
                capacidadeTanque: 0.0, arCondicionado: false, airbags: false, estepe: false, tipoCarroceria: null!, engateReboque: false);

            Veiculo motocicleta = new Motocicleta(preco: 0, marca: null!, modelo: null!, anoFabricacao: 0, cor: null!, capacidadeOcupantes: 0,
                tipoFreio: null!, cambio: null!, placa: null!, tamanhoAro: 0, cilindrada: 0, capacidadeTanque: 0.0, tipo: null!, partida: null!);

            Veiculo bicicleta = new Bicicleta(preco: 0, marca: null!, modelo: null!, anoFabricacao: 0, cor: null!, capacidadeOcupantes: 0,
                tipoFreio: null!, cambio: null!, placa: null!, tamanhoAro: 0, tipo: null!, dobravela: false);

            Veiculo caminhao = new Caminhao(preco: 0, marca: null!, modelo: null!, anoFabricacao: 0, cor: null!, capacidadeOcupantes: 0,
                tipoFreio: null!, cambio: null!, placa: null!, capacidadeCarga: 0, potenciaMotor: 0, tracao: null!, numeroPortas: 0,
                capacidadeTanque: 0.0, arCondicionado: false, airbags: false, estepe: false, numeroEixos: 0);

            Veiculo utilitario = new Utilitario(preco: 0, marca: null!, modelo: null!, anoFabricacao: 0, cor: null!, capacidadeOcupantes: 0,
                tipoFreio: null!, cambio: null!, placa: null!, tipoMisto: null!, numeroPortas: 0, capacidadeTanque: 0.0, arCondicionado: false,
                airbags: false, estepe: false, tipoUtilitario: null!, engateReboque: false);

            if (Veiculos[i] is Automovel)
            {
                automovel.MostrarVeiculos();
            }
            else if (Veiculos[i] is Caminhonete)
            {
                caminhonete.MostrarVeiculos();
            }
            else if (Veiculos[i] is Motocicleta)
            {
                motocicleta.MostrarVeiculos();
            }
            else if (Veiculos[i] is Bicicleta)
            {
                bicicleta.MostrarVeiculos();
            }
            else if (Veiculos[i] is Utilitario)
            {
                utilitario.MostrarVeiculos();
            }
            else if (Veiculos[i] is Caminhao)
            {
                caminhao.MostrarVeiculos();
            }
            Console.ReadKey();
        }
    }
        #endregion
    #region Revenda
    public static Revenda CadastrarRevenda()
        {
            Menu.Cabecalho();
            Console.WriteLine("Cadastrar Revenda");
            Console.WriteLine("------------------");
            Console.Write("Nome da revenda: ");
            string nome = Console.ReadLine()!;
            Console.Write("CNPJ: ");
            string cnpj = Console.ReadLine()!;
            Console.Write("Endereco: ");
            string endereco = Console.ReadLine()!;
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine()!;
            Console.Write("Email: ");
            string email = Console.ReadLine()!;
            return new Revenda(nome, cnpj, endereco, telefone, email);
        }
    public static void MostrarDadosRevenda(Revenda revenda)
        {
            Menu.Cabecalho();
            Console.WriteLine("Dados da Revenda");
            Console.WriteLine("------------------");
            Console.WriteLine($"Nome: {revenda.Nome}");
            Console.WriteLine($"CNPJ: {revenda.CNPJ}");
            Console.WriteLine($"Endereco: {revenda.Endereco}");
            Console.WriteLine($"Telefone: {revenda.Telefone}");
            Console.WriteLine($"Email: {revenda.Email}");
            Console.ReadKey();
        }
    #endregion
}