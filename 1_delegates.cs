using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp3
{

    public delegate void exampleDelegate(string delPar);

    class Program
    {


        static void Main()
        {

            exampleDelegate delob = new exampleDelegate(exampleFun);
            delob("Function Invoked from Delegate");

        }


        public static void exampleFun(string par1)
        {
            Console.WriteLine(par1);
        }

    }



}
