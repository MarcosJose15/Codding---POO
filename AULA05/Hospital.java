public class Hospital{
    public String nome;
    private Medico medico;
    private Paciente paciente;

    public void ContratarOuSubstituir(Medico medico){
        this.medico = medico;
        System.out.println("Seja bem-vindo "+medico);
    }

    public void Desligar(Medico medico){
        this.medico = null;

    }
    public void Internar(Paciente Gomes){
        if(this.hospital == null){
            Console.WriteLine("Infelizmente não temos médico no momento");
        }
    }
}