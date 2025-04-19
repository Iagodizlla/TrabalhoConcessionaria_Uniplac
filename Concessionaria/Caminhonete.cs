//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Caminhonete herda de QuatroRodas
public class Caminhonete : QuatroRodas
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int CapacidadeCarga { get; set; } //em kg
    public string Tracao { get; set; } //4x2, 4x4
    public string Cacamba { get; set; } //aberta/fechada
    public int PotenciaMotor { get; set; } // em cavalos (cv)
    public bool EngateReboque { get; set; }
    public bool SuspensaoReforcada { get; set; }

    // Construtor com base na classe intermediaria
    public Caminhonete(string marca, string modelo, int anoFabricacao, string cor, int capacidadeOcupantes, string combustivel, string cambio,
    double capacidadeTanque, string tipoFreio, double preco, int numeroPortas, bool arCondicionado, bool sistemaSom, bool airbags, bool estepe,  
    int capacidadeCarga, string tracao, string cacamba, int potenciaMotor, bool engateReboque, bool suspensaoReforcada, string placa)
        :base(marca, modelo, anoFabricacao, cor, capacidadeOcupantes, combustivel, cambio, capacidadeTanque, tipoFreio, preco, placa, 
            numeroPortas,  arCondicionado,  sistemaSom, airbags,  estepe)
    {
        CapacidadeCarga = capacidadeCarga;
        Tracao = tracao;
        Cacamba = cacamba;
        PotenciaMotor = potenciaMotor;
        EngateReboque = engateReboque;
        SuspensaoReforcada = suspensaoReforcada;
    }
    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
                $"Tipo: {this.GetType().Name}, " +
                $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
                $"Capacidade de Ocupantes: {CapacidadeOcupantes}, Combustível: {Combustivel}, Câmbio: {Cambio}, " +
                $"Capacidade do Tanque: {CapacidadeTanque}L, Tipo de Freio: {TipoFreio}, Preço: R${Preco}, " +
                $"Placa: {Placa}, Número de Portas: {NumeroPortas}, Ar-condicionado: {ArCondicionado}, " +
                $"Sistema de Som: {SistemaSom}, Airbags: {Airbags}, Estepe: {Estepe}, " +
                $"Capacidade de Carga: {CapacidadeCarga}kg, Tração: {Tracao}, Caçamba: {Cacamba}, " +
                $"Potência do Motor: {PotenciaMotor}cv, Engate para Reboque: {EngateReboque}, " +
                $"Suspensão Reforçada: {SuspensaoReforcada}\n"
        );
    }
}