using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ConstructorInjection
    {
        private IText _text;
        public ConstructorInjection(IText text)
        {
            _text = text;
        }

        public void print()
        {
            _text.print();
        }
    }

    public interface IText
    {
        void print();
    }

    public class Formate : IText
    {
        public void print()
        {
            Console.WriteLine("this is text format");
        }
    }
}
