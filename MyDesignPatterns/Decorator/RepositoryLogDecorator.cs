using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatterns.Decorator
{
    // external library code
    public interface IRepository
    {
        void SaveStuff();
    }

    // external library code
    public class Repository : IRepository
    {
        public void SaveStuff()
        {
            // save stuff   
            Console.WriteLine("Save stuff");
        }
    }

    // external  library code
    class RepoClient
    {
        public void DoSomethig(IRepository repo)
        {
            //...
            repo.SaveStuff();
           
        }
    }

    /*
     * And once you decided, that ALL calls to repository should be logged. 
     * But you have a problem - Repository - class from external library 
     * and you dont want to change that code. 
     * So you need to extend behavior of Repository, which you using. 
     */

    public class RepositoryLogDecorator : IRepository
    {
        public IRepository _inner;

        public RepositoryLogDecorator(IRepository inner)
        {
            _inner = inner;
        }

        public void SaveStuff()
        {
            // log enter to method
            Console.WriteLine("Logging before SaveStuff()");
            try
            {
                _inner.SaveStuff();
            }
            catch (Exception ex)
            {
                // log exception
            }
            // log exit to method
            Console.WriteLine("Logging after SaveStuff()");
        }
    }

    public class RunRepositoryLogDecorator
    {
        public void Run()
        {
            // Before you could use client as
            var client = new RepoClient();
            client.DoSomethig(new Repository());

            // But having the decorator now you can use
            var client2 = new RepoClient();
            client2.DoSomethig(new RepositoryLogDecorator(new Repository()));
        }
    }
}
