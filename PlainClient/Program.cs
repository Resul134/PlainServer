using System;

namespace PlainClient
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
