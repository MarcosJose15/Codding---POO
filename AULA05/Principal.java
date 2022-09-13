public class Principal {
    
    public static void Main(String[] args){
        Hospital hospital = new Hospital();
        hospital.nome = "Restauração";

        Hospital santaLuzia = new Hospital();
        santaLuzia.nome = "Santa Luzia";

        Medico medico = new Medico();
        medico.nome = "Pirulito";

        santaLuzia.ContratarOuSubstituir(medico); 
    }
}
