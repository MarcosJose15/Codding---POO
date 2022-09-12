/* Pensem em 6 entidades do mundo real (Ex.: Um Cachorro, um Carro, uma Empresa, etc - Não podendo ser nenhuma destas) e:
1 - Crie suas respectivas classes;
2 - Insira os atributos que refletem essas classes;
3 - Insira pelo menos 2 métodos que refletem ações de cada uma destas classes;
Linguagens: Java, C# ou TypeScript. */


using System;

public class Program
{
    public static void Main(string[] args, Bebida bebida, Moto fan160, Computador DellElite)
    {
        Moto fan = new Moto();
        fan.modelo = "Honda Fan 160";
        fan.marca = "Honda";
        fan.cilindrada = 150;
        fan.preco = 15000;
        fan.ano = 2023;
        fan.velocidade = "160 Km/h";
        fan.estado = 1;

        Bebida cocaCola = new Bebida();
        cocaCola.nome = "Coca Cola";
        cocaCola.marca = "CocaCola";
        cocaCola.preco = 9.00;
        cocaCola.validade = "10/09/2022";
        cocaCola.dataFabricacao = "22/06/2021";

        Computador dellElite = new Computador();
        dellElite.nome = "Dell Elite";
        dellElite.processador = "Core i7 9600k";
        dellElite.qtdMemoriaRam = 16;
        dellElite.qtdMemoriaRom = 1000000;
        dellElite.placaVideo = "GTX 2080 ti";

        Consulta consulta101 = new Consulta();
        consulta101.nomeMedico = "Antônio Goes Moura";
        consulta101.nomePaciente = "Vanessa camargo Dutra";
        consulta101.horario = "7:00";
        consulta101.hospital = "Santa Luzia";
        consulta101.tempoAtendimento = "50 minutos";
        consulta101.exames = "Eletrocardiograma";

        Endereco enderecoMaria = new Endereco();
        enderecoMaria.rua = "Rua do Principe";
        enderecoMaria.bairro = "Boa Vista";
        enderecoMaria.cidade = "Recife";
        enderecoMaria.estado = "PE";
        enderecoMaria.cep = "50100230";
        enderecoMaria.pais = "Brasil";

        Funcionario Golias = new Funcionario();
        Golias.nome = "Golias Duckeim";
        Golias.dataNasc = "25/06/1989";
        Golias.setor = "Almoxarifado";
        Golias.cargo = "Gerente de estoques";
        Golias.endereco = "Rua da madeira, 107, Torre, Recife, PE";
        Golias.salario = 5300;
    }
}