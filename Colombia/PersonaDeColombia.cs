using Interfaces;
using System;

namespace Colombia
{
    public class PersonaDeColombia : IPersona
    {



        string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        


        public string SayGoodbye()
        {
            return $"Vemos"; 
        }

        public string SayHello()
        {
            return $"Entoncs?";
        }

        public string SayIsCool()
        {
            return $"Vacano";
        }
    }
}
