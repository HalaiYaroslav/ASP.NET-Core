using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkWithVS.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product{ Name = "P1", Price= 275M},
                new Product{ Name = "P2", Price= 48.95M},
                new Product{ Name = "P3", Price= 19.50M},
                new Product{ Name = "P4", Price= 34.95M},
            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }            
        }

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
