public abstract class Funcionario {


    public string Nome { get; set; }
    public int Idade { get; set; }
	public double Salario {get; set;}
	
        protected Funcionario(string nome, int idade, double salario)
    {
        Nome = nome;
        Idade = idade;
        Salario = salario;
    }
	
	public abstract double bonificacao();

}