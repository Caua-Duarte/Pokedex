using System;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = "Bulbassauro";
            p.Descricao = "Pokémon tipo Planta";
            p.ExibirDadosPokemon();
        }
    }
}
