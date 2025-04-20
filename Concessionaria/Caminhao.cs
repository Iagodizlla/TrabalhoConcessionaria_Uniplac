//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Caminhao herda de DeCarga
public class Caminhao : DeCarga
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public int NumeroEixos { get; set; }
    // construtor padrão herdado da classe intermediária
    public Caminhao(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa, int capacidadeCarga,
        int potenciaMotor, string tracao, int numeroPortas, double capacidadeTanque,
        bool arCondicionado, bool airbags, bool estepe, int numeroEixos)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa,
               capacidadeCarga, potenciaMotor, tracao, numeroPortas, capacidadeTanque,
               arCondicionado, airbags, estepe)
    {
        NumeroEixos = numeroEixos;
    }
    // Polimorfismo: sobrescrita do método MostrarVeiculos
    public override void MostrarVeiculos()
    {
        Console.WriteLine(
            $"Tipo: {GetType().Name}, " +
            $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabricacao}, Cor: {Cor}, " +
            $"Capacidade: {CapacidadeOcupantes}, Câmbio: {Cambio}, Freio: {TipoFreio}, " +
            $"Preço: R${Preco}, Placa: {Placa}, Carga útil: {CapacidadeCarga}kg, " +
            $"Potência do motor: {PotenciaMotor}cv, Tração: {Tracao}, Portas: {NumeroPortas}, " +
            $"Tanque: {CapacidadeTanque}L, Ar-condicionado: {ArCondicionado}, Airbags: {Airbags}, " +
            $"Estepe: {Estepe}, Número de eixos: {NumeroEixos}\n"
        );
    }
}