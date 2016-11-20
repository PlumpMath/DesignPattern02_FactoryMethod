using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern02_FactoryMethod.framework
{
    abstract class Factory
    {
        public Product Create(string owner)
        {
            Product product = CreateProduct(owner);
            RegisterProduct(product);
            return product;
        }

        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product product);
    }
}
