using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractHandlerFactory GetFactory(string choice)
        {
            if (choice.Equals("Entity"))
            {
                return new EntityHandlerFactory();
            }
            return null;
        }
    }

    public abstract class AbstractHandlerFactory
    {
        public abstract IEntityHandler GetEntityHandlerFactory(string entityName);
    }
    internal class EntityHandlerFactory : AbstractHandlerFactory
    {
        public override IEntityHandler GetEntityHandlerFactory(string entityName)
        {
            if (entityName == null)
                return null;
            if (entityName == "A")
                return new A();
            if (entityName == "B")
                return new B();
            if (entityName == "C")
                return new C();
            return null;
        }
    }
    public interface IEntityHandler
    {
        Object ViewModel { get; set; }
        void DoOperation(string operationName, string operationFor);
    }

    internal interface IReadable 
    {
        void Read(string operationFor);
    }
    internal interface IMovable 
    {
        void Move(string operationFor);
    }
    internal interface ICopyable 
    {
        void Copy(string operationFor);
    }
    internal interface IDeleteable 
    {
        void Delete(string operationFor);
    }
    internal class Base : IEntityHandler,IReadable, IMovable, ICopyable, IDeleteable
    {
        public Object ViewModel { get; set; }
        public void DoOperation(string operationName, string operationFor)
        {
            if (operationFor == null || operationFor == null)
                return;
            if (operationName == "Read")
                Read(operationFor);
            if (operationName == "Move")
                Move(operationFor);
            if (operationName == "Copy")
                Copy(operationFor);
            if (operationName == "Delete")
                Delete(operationFor);
        }
        public virtual void Read(string operationFor) { }
        public virtual void Move(string operationFor) { }
        public virtual void Copy(string operationFor) { }
        public virtual void Delete(string operationFor) { }
    }
    internal class A : Base
    {
        public override void Read(string operationFor)
        {
            if (operationFor == "Src")
                ReadSrc();
            else if (operationFor == "Dest")
                ReadDest();
        }
        public override void Move(string operationFor)
        {
            if (operationFor == "Src")
                MoveSrc();
            else if (operationFor == "Dest")
                MoveDest();
        }
        public void ReadSrc() { Console.WriteLine("Reading at Source A"); }
        public void ReadDest() { Console.WriteLine("Reading at Dest A"); }
        public void MoveSrc() { Console.WriteLine("Moving at Source A"); }
        public void MoveDest() { Console.WriteLine("Moving at Dest A"); }
    }
    internal class B : Base
    {
        public override void Read(string operationFor)
        {
            if (operationFor == "Src")
                ReadSrc();
            else if (operationFor == "Dest")
                ReadDest();
        }
        public override void Copy(string operationFor)
        {
            if (operationFor == "Src")
                CopySrc();
            else if (operationFor == "Dest")
                CopyDest();
        }
        public void ReadSrc() { Console.WriteLine("Reading at Source B"); }
        public void ReadDest() { Console.WriteLine("Reading at Dest B"); }
        public void CopySrc() { Console.WriteLine("Copying at Source B"); }
        public void CopyDest() { Console.WriteLine("Copying at Dest B"); }
    }
    internal class C : Base
    {
        public override void Read(string operationFor)
        {
            if (operationFor == "Src")
                ReadSrc();
            else if (operationFor == "Dest")
                ReadDest();
        }
        public override void Delete(string operationFor)
        {
            if (operationFor == "Src")
                DeleteSrc();
            else if (operationFor == "Dest")
                DeleteDest();
        }
        public void ReadSrc() { Console.WriteLine("Reading at Source C"); }
        public void ReadDest() { Console.WriteLine("Reading at Dest C"); }
        public void DeleteSrc() { Console.WriteLine("Deleteing at Source C"); }
        public void DeleteDest() { Console.WriteLine("Deleteing at Dest C"); }
    }
    public class EntityViewModel
    {

    }
}
