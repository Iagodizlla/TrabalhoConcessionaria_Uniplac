//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa

namespace Concessionaria;

// Herança intermediária
public class QuatroRodas : Veiculo
{
    public int NumeroPortas { get; set; }
    public bool ArCondicionado { get; set; }
    public bool SistemaSom { get; set; }
    public bool Airbags { get; set; }
    public bool Estepe { get; set; }

    // Construtor com base na superclasse
    public QuatroRodas(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
        double capacidadeTanque, string tipoFreio, double preco, string placa, int numeroPortas, bool arCondicionado, bool sistemaSom, 
        bool airbags, bool estepe)
        : base(marca, modelo, anoFabricacao, cor, capacidadeOcupantes, combustivel, cambio, capacidadeTanque, tipoFreio, preco, placa)
    {
        NumeroPortas = numeroPortas;
        ArCondicionado = arCondicionado;
        SistemaSom = sistemaSom;
        Airbags = airbags;
        Estepe = estepe;
    }
}