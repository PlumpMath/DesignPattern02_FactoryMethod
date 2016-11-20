using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern02_FactoryMethod.framework;
using DesignPattern02_FactoryMethod.idcard;

namespace DesignPattern02_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = new IDCard("Tom");
            Product card2 = new IDCard("Mike");
            Product card3 = new IDCard("Beth");

            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
