using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class MethodInjection
    {
        private ISet _set;
        public void Run(ISet set)
        {
            _set = set;
            _set.Print();
        }
    }
    public interface ISet
    {
        void Print();
    }
    public class Service : ISet
    {
        public void Print()
        {
            Console.WriteLine("Method call and Injection check.");
        }
    }
}
