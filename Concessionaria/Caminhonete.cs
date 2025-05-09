﻿//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;

// Herança: a classe Caminhonete herda de DeCarga
public class Caminhonete : DeCarga
{
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public string TipoCarroceria { get; set; }
    public bool EngateReboque { get; set; }
    // construtor padrão herdado da classe intermediária
    public Caminhonete(double preco, string marca, string modelo, int anoFabricacao, string cor,
        int capacidadeOcupantes, string tipoFreio, string cambio, string placa, int capacidadeCarga,
        int potenciaMotor, string tracao, int numeroPortas, double capacidadeTanque,
        bool arCondicionado, bool airbags, bool estepe, string tipoCarroceria, bool engateReboque)
        : base(preco, marca, modelo, anoFabricacao, cor, capacidadeOcupantes, tipoFreio, cambio, placa,
               capacidadeCarga, potenciaMotor, tracao, numeroPortas, capacidadeTanque,
               arCondicionado, airbags, estepe)
    {
        TipoCarroceria = tipoCarroceria;
        EngateReboque = engateReboque;
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
            $"Estepe: {Estepe}, Tipo de carroceria: {TipoCarroceria}, Engate para reboque: {EngateReboque}\n"
        );
    }
}