public class Gerente : Funcionario

 {
    public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
    {
    }

    public override double bonificacao() 
    {
		
	return this.Salario + 10000;
		
	}

}