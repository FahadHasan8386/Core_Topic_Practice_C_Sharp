using Linq.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Services
{
    public class JoinService
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category {CategoryId = 1 , CategoryName = "Beverages"},
                new Category {CategoryId = 2 , CategoryName = "Condiments"}

            };
        }


        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {ProductId = 1 , ProductName = "Tea"},
                new Product {ProductId = 1 , ProductName = "Coffee"}

            };
        }


        public void ShowJoinResult()
        {
            var categories = GetCategories();
            var products = GetProducts();


            var result =
                   from p in products
                   join c in categories
                   on p.CategoryId equals c.CategoryId
                   select new
                   {
                       p.ProductName,
                       c.CategoryName
                   };


            Console.WriteLine("Product Name : Category");
            Console.WriteLine(".......................");

            foreach(var item in result)
            {
                Console.WriteLine($"{item.ProductName} , {item.CategoryName}");
            }

        }
    }

}
