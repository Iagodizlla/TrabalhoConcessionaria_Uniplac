//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Automovel herda de DePassageiro
public class Automovel : DePassageiro
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int NumeroPortas { get; set; }
    public double CapacidadeTanque { get; set; }
    public bool ArCondicionado { get; set; }
    public bool Airbags { get; set; }
    public bool SistemaSom { get; set; }
    public bool Estepe { get; set; }
    public string Carroceria { get; set; } // Hatch/Sedan/SUV
    // construtor padrão herdado da classe intermediária
    public Automovel(double preco, string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes,
        string tipoFreio, string cambio, string placa, int tamanhoAro, int numeroPortas, double capacidadeTanque,
        bool arCondicionado, bool airbags, bool sistemaSom, bool estepe, string carroceria)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa, tamanhoAro)
    {
        NumeroPortas = numeroPortas;
        CapacidadeTanque = capacidadeTanque;
        ArCondicionado = arCondicionado;
        Airbags = airbags;
        SistemaSom = sistemaSom;
        Estepe = estepe;
        Carroceria = carroceria;
    }
    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
            $"Tipo: {GetType().Name}, " +
            $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
            $"Capacidade: {CapacidadeOcupantes}, Câmbio: {Cambio}, " +
            $"Tanque: {CapacidadeTanque}L, Freio: {TipoFreio}, Preço: R${Preco}, Placa: {Placa}, " +
            $"Aro: {TamanhoAro}, Portas: {NumeroPortas}, Ar-condicionado: {ArCondicionado}, Som: {SistemaSom}, " +
            $"Airbags: {Airbags}, Estepe: {Estepe}, Carroceria: {Carroceria}\n"
        );
    }
}