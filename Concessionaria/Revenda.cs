//Iago Henrique Schlemper
//Eduardo Da Silva Ramos
//Arthur Barbosa
namespace Concessionaria;


// Abstração: Classe Revenda para representar uma revenda de veículos
public class Revenda
{
    // Abstração: esta classe representa o conceito de uma revenda de veículos
    // Encapsulamento: uso de propriedades com get/set para acessar os atributos
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    // Construtor padrao
    public Revenda(string nome, string cnpj, string endereco, string telefone, string email)
    {
        Nome = nome;
        CNPJ = cnpj;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
    }
}
