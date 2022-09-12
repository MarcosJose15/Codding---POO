public class Moto
{
    public string modelo;
    public string marca;
    public int cilindrada;
    public float preco;
    public int ano;
    public string velocidade;
    public int estado;

    public void acelerar(){

        //Enquanto a moto estiver ligada
        if (this.estado == 'l')
        {
            Console.WriteLine($"Estou acelerando em {this.velocidade} Km/h");
        }
        else
        {
            Console.WriteLine($"Moto Desligada");
        }

    
        { if (this.preco < 15000)
        {
            Console.WriteLine($"O preço caiu para {this.preco}");
            
        }
        }

}}