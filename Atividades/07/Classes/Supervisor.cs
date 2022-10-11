public class Supervisor : Funcionario

 {
    public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
    {
    }

    public override double bonificacao() 
    {
		
	return this.Salario + 5000;
		
	}

}