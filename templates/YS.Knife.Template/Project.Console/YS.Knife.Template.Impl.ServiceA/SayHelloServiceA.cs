using System;

namespace YS.Knife.Template.Impl.ServiceA
{
    [Service]
    public class SayHelloServiceA : ISayHelloService
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello,{name}. I'm from serviceA.");
        }
    }
}
