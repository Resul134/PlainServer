using System;

namespace PlainServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker();
            work.Start();
        }
    }
}
