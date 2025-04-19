namespace Concessionaria;

public class Revenda
{
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    public Revenda(string nome, string cnpj, string endereco, string telefone, string email)
    {
        Nome = nome;
        CNPJ = cnpj;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
    }
}
