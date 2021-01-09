using YS.Knife.Hosting;

namespace YS.Knife.Template.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new KnifeHost(args))
            {
                host.Run();
            }
        }
    }
}
