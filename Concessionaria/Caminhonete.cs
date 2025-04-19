//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

public class Caminhonete : QuatroRodas
{
    public int CapacidadeCarga { get; set; } //em kg
    public string Tracao { get; set; } //4x2, 4x4
    public string Cacamba { get; set; } //aberta/fechada
    public int PotenciaMotor { get; set; } // em cavalos (cv)
    public bool EngateReboque { get; set; }
    public bool SuspensaoReforcada { get; set; }

    public Caminhonete(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
    double capacidadeTanque, string tipoFreio, double preco, int numeroPortas, bool arCondicionado, bool sistemaSom, bool airbags, bool estepe,  
    int capacidadeCarga, string tracao, string cacamba, int potenciaMotor, bool engateReboque, bool suspensaoReforcada, string placa)
    {
        CapacidadeCarga = capacidadeCarga;
        Tracao = tracao;
        Cacamba = cacamba;
        PotenciaMotor = potenciaMotor;
        EngateReboque = engateReboque;
        SuspensaoReforcada = suspensaoReforcada;
        //4Rodas
        NumeroPortas = numeroPortas;
        ArCondicionado = arCondicionado;
        SistemaSom = sistemaSom;
        Airbags = airbags;
        Estepe = estepe;

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