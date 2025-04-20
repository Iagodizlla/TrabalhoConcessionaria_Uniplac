//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Bicicleta herda de DePassageiro
public class Bicicleta : DePassageiro
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public string Tipo { get; set; } // Mountain/BMX/Cross
    public bool Dobravela { get; set; }
    // construtor padrão herdado da classe intermediária
    public Bicicleta(double preco, string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes,
        string tipoFreio, string cambio, string placa, int tamanhoAro, string tipo, bool dobravela)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa, tamanhoAro)
    {
        Tipo = tipo;
        Dobravela = dobravela;
    }
    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
            $"Tipo: {GetType().Name}, " +
            $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
            $"Capacidade: {CapacidadeOcupantes}, Câmbio: {Cambio}, " +
            $"Freio: {TipoFreio}, Preço: R${Preco}, Placa: {Placa}, Aro: {TamanhoAro}, " +
            $"Tipo: {Tipo}, Dobrável: {Dobravela}\n"
        );
    }
}