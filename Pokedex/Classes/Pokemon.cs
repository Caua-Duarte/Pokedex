using System;

namespace Pokedex
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set 
            { 
                string texto = value;
                this.nome = texto; 
            }
        }

        private string descricao;
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        
        public void ExibirDadosPokemon()
        {
            Console.WriteLine ("Nome do Pokémon: " + this.Nome);
            Console.WriteLine ("Descrição do Pokémon: " + this.Descricao);
        }
        
    }
}