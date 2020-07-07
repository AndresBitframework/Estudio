using Interfaces;
using System;

namespace ElSalvador
{
    public class PersonaDelSalvador : IPersona
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string SayGoodbye()
        {
            return $"Salu";
        }

        public string SayHello()
        {
            return $"Que Ondas";
        }

        public string SayIsCool()
        {
            return $"Chivo";
        }
    }
}
