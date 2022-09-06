//1 - Crie uma classe “Jogo” com os atributos: “Fabricante”, "Nome", "Nota", em C#, no Java e no TypeScript, seguindo o exemplo a seguir:

//Java/C#
public class Jogo{
    String Fabricante;
    String Nome;
    float Nota;
}

//1 - Crie uma classe “Jogo” com os atributos: “Fabricante”, "Nome", "Nota", em C#, no Java e no TypeScript, seguindo o exemplo a seguir:

//Java/C#
public class Jogo{
    String fabricante;
    String nome;
    float nota;
}



//2 - Seguindo a lógica do exercício anterior, pense em três classes distintas, e mapeie seus atributos, descrevendo a classe no mesmo modelo utilizado anteriormente (Java/C#/Typescript - Escolha).

//Java/C#
public class Filme{
    String nome;
    int id;
    String duracao;
    int  classificacao;
    String descricao;
    String produtora;
}



//Java/C#
puclic class Funcionario{
    String nome;
    String dataNasc;
    String cpf;
    String rg;
    String endereco;
    float salario;
}



//Java/C#
public class Televisao{
    String marca;
    String modelo;
    String dataFabricacao;
    float preco;
    int numeroSerie;
}



//3 - No método principal (ou numa classe à parte no TypeScript), instancie todos os objetos.

public class Program{

    public static void Main(string[] args){

        Jogo xadrez = new Jogo();
        xadrez.fabricacão = "26/01/2017";
        xadrez.fome = "Xadrez";
        xadrez.fota = 10;


        Filme f012 = new Filme();
        f012.nome = "Procurando Nemo";
        f012.id = 012;
        f012.duracao = "02:15:00";
        f012.classificacao = 0;
        f012.descricao = "Na história acompanhamos a trajetória de Nemo, um peixinho-palhaço que nasceu com uma deficiência e tem uma de suas nadadeiras menor que a outra. Ele é capturado por um mergulhador e acaba indo parar no aquário de um dentista na Austrália. Enquanto isso, seu pai, o superprotetor Marlin, fica desesperado e percorre os sete mares atrás do filho. Para tanto ele irá contar com a ajuda de Dory, um peixe-fêmea que tem perda de memória recente e fala 'baleies' (por sinal, uma das cenas mais engraçadas da história das animações). Como toda boa animação, Procurando Nemo nos apresenta um conto em que as relações familiares e de amizade são o porto seguro de seus personagens principais. Mas esta questão, que pode ser considerada (na verdade até é) clichê, é tratada de forma tão bonita, divertida e com extrema inteligência que não se pode deixar de notar os inúmeros paralelos com a realidade dos espectadores, sejam crianças ou adultos. É aí que o filme se diferencia dos demais e mostra sua maturidade.";
        f012.produtora = "Pixels";
   

        Funcionario Raquel = new Funcionario();
        Raquel.nome = "Raquel Soares Dutra Falcão";
        Raquel.dataNasc = "23/09/1998";
        Raquel.cpf = "024.756.089-39";
        Raquel.rg = "34352056";
        Raquel.endereco = "Ruan Antônio Falcão, Torre, Recife, Pernambuco, Brasil";
        Raquel.salario = 5.678;
        

        Televisao AOC112 = new Televisao();
        AOC112.marca = "AOC";
        AOC112.modelo = "AOC-112" ;
        AOC112.dataFabricacao = "25/05/2022";
        AOC112.preco = 2.000;
        AOC112.numeroSerie = 121316175436293481234456;
    }


}