using System;

namespace Interfaces
{
    public interface IPersona
    {
        string SayHello();

        string SayIsCool();

        string SayGoodbye();

        string Name { get; set; }
    }
}
