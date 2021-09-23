using System;

namespace M008_01_Interfaces_CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleClass = new SampleClass();
            sampleClass.MakeSomething();

            ISampleInterface sampleClass2 = new SampleClass();
            sampleClass2.MakeSomething();
            sampleClass2.DefaultMethode();


            IMyIntefaceWithOtherInterface myIntefaceWithOtherInterface = new SampleClassWithAbstractInterface();
            myIntefaceWithOtherInterface.HelloWorld();
            myIntefaceWithOtherInterface.TheNormalOneHelloWorld();
        }
    }

    public interface ISampleInterface
    {
        public void MakeSomething();

        public void DefaultMethode() //Wird verwendet, wenn diese Implementierung in mehreren Klassen verwendet wird. 
        {
            Console.WriteLine("ISampleInterface.DefaultMethode -> Ich bin eine Default-Implementierung");
        }
    }

    public interface IMyInterfaceWithAbstractMethode
    {
         abstract void HelloWorld();

         void TheNormalOneHelloWorld();
    }

    public interface IMyIntefaceWithOtherInterface : IMyInterfaceWithAbstractMethode
    {
        void IMyInterfaceWithAbstractMethode.HelloWorld()
        {
            Console.WriteLine("Implementation of abstract void HelloWorld();");
        }
    }

    public class SampleClassWithAbstractInterface : IMyIntefaceWithOtherInterface
    {
        public void TheNormalOneHelloWorld()
        {
            Console.WriteLine("SampleClassWithAbstractInterface.TheNormalOneHelloWorld()");
        }
    }

    public class MyImplementationClass : IMyInterfaceWithAbstractMethode
    {
        public void HelloWorld()
        {
            throw new NotImplementedException();
        }

        public void TheNormalOneHelloWorld()
        {
            throw new NotImplementedException();
        }
    }







    public class SampleClass : ISampleInterface
    {
        public void MakeSomething()
        {
            Console.WriteLine("SampleClass.MakeSomething-Implementierung");
        }
    }
}
