//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Motocicleta herda de DePassageiro
public class Motocicleta : DePassageiro
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int Cilindrada { get; set; }
    public double CapacidadeTanque { get; set; }
    public string Tipo { get; set; } // street/esportiva/trail/custom
    public string Partida { get; set; } // elétrica ou pedal
    // construtor padrão herdado da classe intermediária
    public Motocicleta(double preco, string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes,
        string tipoFreio, string cambio, string placa, int tamanhoAro, int cilindrada, double capacidadeTanque,
        string tipo, string partida)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa, tamanhoAro)
    {
        Cilindrada = cilindrada;
        CapacidadeTanque = capacidadeTanque;
        Tipo = tipo;
        Partida = partida;
    }

    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
            $"Tipo: {GetType().Name}, " +
            $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
            $"Capacidade: {CapacidadeOcupantes}, Freio: {TipoFreio}, Câmbio: {Cambio}, " +
            $"Placa: {Placa}, Tamanho do aro: {TamanhoAro}, Cilindrada: {Cilindrada}cc, " +
            $"Tanque: {CapacidadeTanque}L, Tipo: {Tipo}, Partida: {Partida}, Preço: R${Preco}\n"
        );
    }
}