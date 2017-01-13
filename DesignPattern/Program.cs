using System;
using AbstractFactory;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandlerFactory factory = FactoryProducer.GetFactory("Entity");
            factory.GetEntityHandlerFactory("A").DoOperation("Read","Dest");
            factory.GetEntityHandlerFactory("B").DoOperation("Copy","Dest");
            factory.GetEntityHandlerFactory("C").DoOperation("Delete","Src");
            Console.ReadLine();
        }
    }
}
