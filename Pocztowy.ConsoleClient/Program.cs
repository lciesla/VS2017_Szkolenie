using Pocztowy.Calculators;
using Pocztowy.FakeRepositories;
using Pocztowy.IRepositories;
using Pocztowy.Models;
using System;
using System.Collections.Generic;

namespace Pocztowy.ConsoleClient
{
    public abstract class Person
    {
        public virtual void DoWork()
        {
            Console.WriteLine("working...");
        }
    }

    public class Man : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("sleeping...");
        }
    }

    public class Woman : Person
    {

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

        }

        private static decimal Calculate(int qty, int unitprice)
        {
            throw new NotImplementedException();
        }

        private static void Send(string message)
        {
            throw new NotImplementedException();
        }
    }
}
