public class Moto
{
    public string modelo;
    public string marca;
    public int cilindrada;
    public float preco;
    public int ano;
    
    public int velocidade;
    public bool estado;

    public void acelerar(){

        //Enquanto a moto estiver ligada
        if (this.estado == 'l')
        {
            Console.WriteLine($"Estou acelerando em {velocidade} Km/h");
            
        }

    }
}


    
