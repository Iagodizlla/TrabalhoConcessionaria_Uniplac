//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Motocicleta herda de Veiculo
public class Motocicleta : Veiculo
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int Cilindrada { get; set; } //150cc, 600cc, etc...
    public string Tipo { get; set; } //Street, Esportiva, Trail ou Custom
    public string Partida { get; set; } //Elétrica ou Pedal

    // Construtor com base na superclasse
    public Motocicleta(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
    double capacidadeTanque, string tipoFreio, double preco, int cilindrada, string tipo, string partida, string placa) 
        : base(marca, modelo, anoFabricacao, cor, capacidadeOcupantes, combustivel, cambio, capacidadeTanque, tipoFreio, preco, placa)
    {
        Cilindrada = cilindrada;
        Tipo = tipo;
        Partida = partida;
    }
    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
                $"Tipo: {this.GetType().Name}, " +
                $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
                $"Capacidade de Ocupantes: {CapacidadeOcupantes}, Combustível: {Combustivel}, Câmbio: {Cambio}, " +
                $"Capacidade do Tanque: {CapacidadeTanque}L, Tipo de Freio: {TipoFreio}, Preço: R${Preco}, " +
                $"Cilindrada: {Cilindrada}cc, Tipo: {Tipo}, Partida: {Partida}, Placa: {Placa}\n"
        );
    }
}