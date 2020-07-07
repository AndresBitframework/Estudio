using Colombia;
using ElSalvador;
using Interfaces;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaDeColombia colombia = new PersonaDeColombia();
            PersonaDelSalvador salvador = new PersonaDelSalvador();

            Platicar(colombia);
            Platicar(salvador);
            Console.ReadLine();
        }

        static void Platicar(IPersona persona)
        {
            Console.WriteLine("Asi Dice Hola");
            Console.WriteLine(persona.SayHello());
            Console.WriteLine("Asi Dice Bueno");
            Console.WriteLine(persona.SayIsCool());
            Console.WriteLine("Asi Dice Adios");
            Console.WriteLine(persona.SayGoodbye());

        }
    }
}
