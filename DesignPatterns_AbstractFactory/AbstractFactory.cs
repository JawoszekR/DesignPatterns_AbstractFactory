using DesignPatterns_AbstractFactory.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract ClassA GetClassA();
        public abstract ClassB GetClassB();
    }
}
