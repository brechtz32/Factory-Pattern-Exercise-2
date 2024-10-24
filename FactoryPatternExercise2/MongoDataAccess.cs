using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to your Mongo Database. . .");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your Mong Database. . .");

            return new List<Product>()
            {
            new Product() { Name = "Pearl Jam Ten", Price = 12.99m },
            new Product() { Name = "Megaman X Collection", Price = 59.99m },
            new Product() { Name = "Keyboard", Price = 120.99m },
            new Product() { Name = "Monitor", Price = 159.99m },
            new Product() { Name = "Mouse", Price = 65.99m },
            new Product() { Name = "Desk", Price = 250.99m },
            new Product() { Name = "Poser Supply", Price = 120.99m }
            };
        }                 
    }
}
