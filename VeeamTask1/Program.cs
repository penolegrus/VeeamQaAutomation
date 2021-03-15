using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace VeeamTask1
{
    class Program
    {
        static void Main(string[] args)
        {            
            CheckTime checkTime = new CheckTime(args[0], args[1], args[2]);
        }
        
    }
}

