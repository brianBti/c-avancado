﻿namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio
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
    }
}