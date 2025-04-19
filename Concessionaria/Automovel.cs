//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Automovel herda de QuatroRodas
public class Automovel : QuatroRodas
{
    public string Carroceria { get; set; }  //Hatch ou Sedan

    // Construtor com base na classe intermediaria
    public Automovel(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
        double capacidadeTanque, string tipoFreio, double preco, string placa, int numeroPortas, bool arCondicionado, bool sistemaSom,
        bool airbags, bool estepe, string carroceria)
        : base(marca, modelo, anoFabricacao, cor, capacidadeOcupantes, combustivel, cambio, capacidadeTanque, tipoFreio, preco, placa,
            numeroPortas, arCondicionado, sistemaSom, airbags, estepe)
    {
        Carroceria = carroceria;
    }
}