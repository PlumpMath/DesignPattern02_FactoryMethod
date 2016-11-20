using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern02_FactoryMethod.framework;

namespace DesignPattern02_FactoryMethod.idcard
{
    class IDCard : Product
    {
        string owner;

        public IDCard(string owner)
        {
            Console.WriteLine("create an IDCard of " + owner + ".");
            this.owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine("use an IDCard of " + owner + ".");
        }

        public string GetOwner()
        {
            return owner;
        }
    }
}
