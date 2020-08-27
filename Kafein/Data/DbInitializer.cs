using Kafein.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kafein.Data
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            // Creates DB if not exists.
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded.
            }

            var users = new User[]
            {
                new User{TCKN="11111111111", Name="Orhun", Surname="Akture", Phone="5339207240", Email="orhunakture@hotmail.com"},
                new User{TCKN="22222222222", Name="User2", Surname="UserS1", Phone="5331111111", Email="user1@hotmail.com"},
                new User{TCKN="33333333333", Name="User3", Surname="UserS1", Phone="5332222222", Email="user2@hotmail.com"},
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{Name="Product 1", Description="Product 1 Desc.", Price=(decimal)11.50},
                new Product{Name="Product 2", Description="Product 2 Desc.", Price=(decimal)12.50},
                new Product{Name="Product 3", Description="Product 3 Desc.", Price=(decimal)13.50},
                new Product{Name="Product 4", Description="Product 4 Desc.", Price=(decimal)14.50},
                new Product{Name="Product 5", Description="Product 5 Desc.", Price=(decimal)15.50},
                new Product{Name="Product 6", Description="Product 6 Desc.", Price=(decimal)16.50},
                new Product{Name="Product 7", Description="Product 7 Desc.", Price=(decimal)17.50},
                new Product{Name="Product 8", Description="Product 8 Desc.", Price=(decimal)18.50},
                new Product{Name="Product 9", Description="Product 9 Desc.", Price=(decimal)19.50}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }
    }
}
