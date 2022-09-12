public class Funcionario
{
    public string nome;
    public string dataNasc;
    public string setor;
    public string cargo;
    public string endereco;
    public int salario;

    {
    if(this.salario > 3000)
    {
        Console.WriteLine("Você deverá pagar imposto de renda");
    }
    else
    {
        Console.WriteLine("Você não deverá pagar imposto de renda");
    }
    }
}