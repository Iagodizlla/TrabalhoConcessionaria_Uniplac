//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Abstração: Classe genérica para representar qualquer veículo
public abstract class Veiculo
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public double Preco { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoFabricacao { get; set; }
    public string Cor { get; set; }
    public int CapacidadeOcupantes { get; set; }
    public string TipoFreio { get; set; }
    public string Cambio { get; set; }
    public string Placa { get; set; }
    // Construtor padrão
    protected Veiculo(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa)
    {
        Preco = preco;
        Marca = marca;
        Modelo = modelo;
        AnoFabricacao = anoFabricacao;
        Cor = cor;
        CapacidadeOcupantes = capacidadeOcupantes;
        TipoFreio = tipoFreio;
        Cambio = cambio;
        Placa = placa;
    }
    // Polimorfismo: método abstrato para mostrar os veículos
    public abstract void MostrarVeiculos();
}