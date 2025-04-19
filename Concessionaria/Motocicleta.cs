//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Motocicleta herda de Veiculo
public class Motocicleta : Veiculo
{
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
}