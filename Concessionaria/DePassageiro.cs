//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe DePassageiro herda de Veiculo
public abstract class DePassageiro : Veiculo
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int TamanhoAro { get; set; }
    // construtor padrão herdado da classe base
    protected DePassageiro(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa, int tamanhoAro)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa)
    {
        TamanhoAro = tamanhoAro;
    }
}