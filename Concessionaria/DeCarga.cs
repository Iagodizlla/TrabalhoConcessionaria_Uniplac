//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe DeCarga herda de Veiculo
public abstract class DeCarga : Veiculo
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int CapacidadeCarga { get; set; }
    public int PotenciaMotor { get; set; }
    public string Tracao { get; set; }
    public int NumeroPortas { get; set; }
    public double CapacidadeTanque { get; set; }
    public bool ArCondicionado { get; set; }
    public bool Airbags { get; set; }
    public bool Estepe { get; set; }
    // construtor padrão herdado da classe base
    protected DeCarga(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa, int capacidadeCarga,
        int potenciaMotor, string tracao, int numeroPortas, double capacidadeTanque,
        bool arCondicionado, bool airbags, bool estepe)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa)
    {
        CapacidadeCarga = capacidadeCarga;
        PotenciaMotor = potenciaMotor;
        Tracao = tracao;
        NumeroPortas = numeroPortas;
        CapacidadeTanque = capacidadeTanque;
        ArCondicionado = arCondicionado;
        Airbags = airbags;
        Estepe = estepe;
    }
}