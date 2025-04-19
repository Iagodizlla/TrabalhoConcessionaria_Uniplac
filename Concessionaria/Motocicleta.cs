using System.Numerics;

namespace Concessionaria;

public class Motocicleta : Veiculo
{
    public int Cilindrada { get; set; } //150cc, 600cc, etc...
    public string Tipo { get; set; } //Street, Esportiva, Trail ou Custom
    public string Partida { get; set; } //Elétrica ou Pedal

    public Motocicleta(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
    double capacidadeTanque, string tipoFreio, double preco, int cilindrada, string tipo, string partida, string placa)
    {
        Cilindrada = cilindrada;
        Tipo = tipo;
        Partida = partida;
        //Veiculo
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