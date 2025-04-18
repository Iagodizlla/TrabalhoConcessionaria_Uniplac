namespace Concessionaria;

public class Automovel : QuatroRodas
{
    public string Carroceria { get; set; }  //Hatch ou Sedan

    public Automovel(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
    double capacidadeTanque, string tipoFreio, double preco, int numeroPortas, bool arCondicionado, bool sistemaSom, bool airbags, bool estepe,
    string carroceria)
    {
        Carroceria = carroceria;
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
    }
}