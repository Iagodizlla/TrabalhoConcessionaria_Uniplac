namespace Concessionaria;

public class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoFabricacao { get; set; }
    public string Cor { get; set; }
    public int CapacidadeOcupantes { get; set; }
    public string Combustivel { get; set; } //Gasolina, Álcool, Flex, Elétrico
    public string Cambio { get; set; } //manual/automático
    public double CapacidadeTanque { get; set; } // em litros
    public string TipoFreio { get; set; } //Disco, Tambor, ABS
    public double Preco { get; set; }
    public string Placa { get; set; } //Placa do veículo

}