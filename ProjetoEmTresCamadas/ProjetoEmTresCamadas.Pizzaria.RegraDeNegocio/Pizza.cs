namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio
{
    public enum TamanhoDePizza
    {
        Pequena = 0,
        Media = 1,
        grande = 2
    }
    public class Pizza
    {
        
        public string Sabor { get; set; }

        public TamanhoDePizza TamanhoDePizza { get; set; }
        public string Descricao { get; set; }  
        
        public Pizza()
        {

        }

        public Pizza CriarPizza (string sabor, TamanhoDePizza tamanhoDePizza, string descricao = "")
        {
            Sabor = sabor;
            this.TamanhoDePizza = tamanhoDePizza;
            if (string.IsNullOrEmpty(descricao))
            {
                Descricao = descricao;
            }
            return this;
        }

        public string DefinirSabor(string sabor)
        {
            if (sabor == "C")
            {
                Sabor = "Calabresa";
            }
            else if (sabor == "F")
            {
                Sabor = "Frango";
            }
            return Sabor;
        }

        public string DefinirTamanho(string tamanho)
        {
            switch (tamanho)
            {
                case "P":
                    {
                        TamanhoDePizza = TamanhoDePizza.Pequena;
                        break;
                    }
                case "M":
                    {
                        TamanhoDePizza = TamanhoDePizza.Media;
                        break;
                    }
                case "G":
                    {
                        TamanhoDePizza = TamanhoDePizza.grande;
                        break;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            };
            return Enum.GetName(TamanhoDePizza);
      
        }
        public override string ToString()
        {
            return $"Sua Pizza é de sabor {Sabor} e tamanho é  de {TamanhoDePizza}";
        }
    }
}