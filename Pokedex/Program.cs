    using System;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon("Bulbassauro","Pokémon tipo Planta");
            Pokemon p1 = new Pokemon();
            p.ExibirDadosPokemon(true);
        }
    }
}
