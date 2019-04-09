using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_AbstractFactory.Types;

namespace DesignPatterns_AbstractFactory
{
    class Factory1 : AbstractFactory
    {
        public override ClassA GetClassA()
        {
            return new ClassA1();
        }

        public override ClassB GetClassB()
        {
            return new ClassB1();
        }
    }
}
