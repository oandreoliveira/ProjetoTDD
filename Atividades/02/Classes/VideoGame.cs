 public class VideoGame : Produto, Imposto
    {
        public string Marca { get; private set;  }
        public string Modelo { get; private set;  }
        public bool IsUsado { get; private set;  }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }


    public double CalculaImposto()
    {
            if (IsUsado == true)
            {
                return Preco * 0.25;
            }
            return Preco * 0.45;
    }
}