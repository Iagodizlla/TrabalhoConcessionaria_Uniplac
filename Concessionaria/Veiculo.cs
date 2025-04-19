//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Abstração: Classe genérica para representar qualquer veículo
public class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoFabricacao { get; set; }
    public string Cor { get; set; }
    public int CapacidadeOcupantes { get; set; }
    public string Combustivel { get; set; } //Gasolina, Álcool, Flex, Elétrico
    public string Cambio { get; set; } //manual/automático
    public double CapacidadeTanque { get; set; } // em litros
    public string TipoFreio { get; set; } //Disco, Tambor, ABS
    public double Preco { get; set; }
    public string Placa { get; set; } //Placa do veículo

    // Construtor padrão
    public Veiculo(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
        double capacidadeTanque, string tipoFreio, double preco, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        AnoFabricacao = anoFabricacao;
        Cor = cor;
        CapacidadeOcupantes = capacidadeOcupantes;
        Combustivel = combustivel;
        Cambio = cambio;
        CapacidadeTanque = capacidadeTanque;
        TipoFreio = tipoFreio;
        Preco = preco;
        Placa = placa;
    }
}