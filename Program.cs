using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace entityframeworkcore
{
    class Program
    {
        static void Main (string[] args)
        {
            using (var context = new EFCoreDemoContext ())
            {
                var author = new Author
                {
                FirstName = "Neale",
                LastName = "Forrest",
                Books = new List<Book>
                {
                new Book { Title = "One" },
                new Book { Title = "Two" },
                new Book { Title = "Three" },
                }
                };
                context.Add (author);
                context.SaveChanges ();

                var data = context.Books.Where(x => EF.Functions.Like(x.Title, "%e%"));
                var data2 = context.Books.Where(x => EF.Functions.);
                Console.WriteLine(data.Count());
            }
        }
    }
}