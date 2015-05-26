using System;
using System.Threading;

namespace Test.Wpf.Interfaces
{
    public interface IState
    {
        string Name { get; set; }

        IEvent[] Events { get; }
    }
}