using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace M010_05_SOLID_InterfaceSegregationPrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            IA sampleInstanceA = new MyABC();
            sampleInstanceA.MethodeA();

            IB sampleInstanceB = new MyABC();
            sampleInstanceB.MethodeB();

            IABC sampleInstanceC = new MyABC();
            sampleInstanceC.MethodeA();
            sampleInstanceC.MethodeB();
            sampleInstanceC.MethodeC();
        }
    }

    #region BadCode 
    public interface IReadRepository<T>
    {
        IList<T> GetAll();

        IList<T> GetByStatement(Expression<Func<int, bool>> predicate); //Lambda als Parameter

        T GetById(int Id);
    }

    public interface IRepository<T> : IReadRepository<T>
    {
        //Methoden hätten jeweils in ihrem eigenen Interface ausgelagert werden sollen. 
        public void Insert(T item);
        public void Update(int Id, T modifiedItem);

        public void Delete(int Id);
    }


    public class RepositoryBase<T> : IRepository<T>
    {

        //DbContext -> Verbindung zu DB
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetByStatement(Expression<Func<int, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, T modifiedItem)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Goode Code

    public interface IA
    {
        void MethodeA();
    }

    public interface IB
    {
        void MethodeB();
    }

    public interface IC
    {
        void MethodeC();
    }

    public interface IABC : IA, IB, IC
    {
        //kann man weiteres noch implementieren 
    }

    public class MyABC : IABC
    {
        public void MethodeA()
        {
            throw new NotImplementedException();
        }

        public void MethodeB()
        {
            throw new NotImplementedException();
        }

        public void MethodeC()
        {
            throw new NotImplementedException();
        }
    }
    #endregion



}
