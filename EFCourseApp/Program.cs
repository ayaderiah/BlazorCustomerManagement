using System;
using EFCourseApp; 

namespace EFCourseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            using (var _context = new ApplicationDbContext())
            {
                Console.WriteLine("Adding new records to the temporary memory...");

                
                var newCustomer = new Customer
                {
                    Name = "Aya Deriah",
                    Email = "aya@example.com"
                };

                
                var newProduct = new Product
                {
                    Name = "Mechanical Keyboard",
                    Price = 75.99m 
                };

                
                _context.Customers.Add(newCustomer);
                _context.Products.Add(newProduct);

               
                _context.SaveChanges();

                Console.WriteLine("Success! The new Customer and Product have been saved into FinalDemoDb. 🎉");
            }

            Console.ReadLine(); 
        }
    }
}
