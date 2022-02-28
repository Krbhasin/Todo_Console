using System;
using TODO.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace TODO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(var context = new TodoContext())
            {
                context.Database.EnsureCreated();
            }
            //insertProduct();
            readProduct();
            //deleteProduct();
            updateProduct();
            readProduct();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
 
        static void insertProduct()
        {
            using (var db = new TodoContext())
            {
                Product product = new Product();
                product.Name = "Pen Drive";
                db.Add(product);
 
                product = new Product();
                product.Name = "Memory Card";
                db.Add(product);
 
                db.SaveChanges();
            }
            return;
        }
        static void readProduct()
        {
        
            using (var db = new TodoContext())
            {
                List<Product> products = db.Products.ToList();
                foreach (Product p in products)
                {
                    Console.WriteLine("{0} {1}", p.Id, p.Name);
                }
            }
            return;
        }
        static void deleteProduct()
        {
            using (var db = new TodoContext())
            {
        
                Product product = db.Products.Find(2);
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return;
        }
        static void updateProduct()
        {
            using (var db = new TodoContext())
            {
                Product product = db.Products.Find(1);
                product.Name = "Better Pen Drive";
                db.SaveChanges();
            }
            return;
        }
    }
}
