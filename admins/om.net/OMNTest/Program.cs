﻿using System;
using System.IO;
using Db4objects.Db4o;

namespace OMNTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new CreateEnumDatabase().Run();
            new CreateDateTimeDatabase().Run();
            Console.WriteLine("Start Server");
            new CreateDateTimeDatabase().RunServer(9988);
            Console.WriteLine("End.");
        }
    }

}
