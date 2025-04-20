//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Utilitario herda de DeMisto
public class Utilitario : DeMisto
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public string TipoUtilitario { get; set; } // Tradicional/Leve
    public bool EngateReboque { get; set; }
    // construtor padrão herdado da classe intermediária
    public Utilitario(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa, string tipoMisto,
        int numeroPortas, double capacidadeTanque, bool arCondicionado, bool airbags, bool estepe,
        string tipoUtilitario, bool engateReboque)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa,
               tipoMisto, numeroPortas, capacidadeTanque, arCondicionado, airbags, estepe)
    {
        TipoUtilitario = tipoUtilitario;
        EngateReboque = engateReboque;
    }
    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
            $"Tipo: {GetType().Name}, " +
            $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
            $"Capacidade: {CapacidadeOcupantes}, Freio: {TipoFreio}, Câmbio: {Cambio}, Placa: {Placa}, " +
            $"Tipo Misto: {TipoMisto}, Portas: {NumeroPortas}, Tanque: {CapacidadeTanque}L, " +
            $"Ar-condicionado: {ArCondicionado}, Airbags: {Airbags}, Estepe: {Estepe}, " +
            $"Tipo Utilitário: {TipoUtilitario}, Engate para Reboque: {EngateReboque}, Preço: R${Preco}\n"
        );
    }
}