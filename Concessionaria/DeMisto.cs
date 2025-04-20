//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe DeMisto herda de Veiculo
public abstract class DeMisto : Veiculo
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public string TipoMisto { get; set; }
    public int NumeroPortas { get; set; }
    public double CapacidadeTanque { get; set; }
    public bool ArCondicionado { get; set; }
    public bool Airbags { get; set; }
    public bool Estepe { get; set; }
    // construtor padrão herdado da classe base
    protected DeMisto(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa, string tipoMisto,
        int numeroPortas, double capacidadeTanque, bool arCondicionado, bool airbags, bool estepe)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa)
    {
        TipoMisto = tipoMisto;
        NumeroPortas = numeroPortas;
        CapacidadeTanque = capacidadeTanque;
        ArCondicionado = arCondicionado;
        Airbags = airbags;
        Estepe = estepe;
    }
}