using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Name = "Squirtle";
            pokemon.Number = "#007";
            pokemon.Height = 1.08f;
            pokemon.Weight = 19.8f;
            pokemon.Category = "Tiny Turtle";
            pokemon.Abilities = "Torrent";
            pokemon.Gender = "Male";
            Console.WriteLine("名字:{0}, 編號:{1},身高:{2}公尺,體重:{3}磅,類別:{4},能力:{5},性別:{6}",
                pokemon.Name, pokemon.Number, pokemon.Height, pokemon.Weight, pokemon.Category, pokemon.Abilities,
                pokemon.Gender);
        }
    }
}