public class Vendedor : Funcionario

 {
    public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
    {
    }

    public override double bonificacao() 
    {
		
	return this.Salario + 3000;
		
	}

}