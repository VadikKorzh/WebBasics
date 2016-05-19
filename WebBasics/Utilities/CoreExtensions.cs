using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBasics.Models;

namespace WebBasics.Utilities
{
    public static class CoreExtensions
    {
        public static void Add(this IList<Book> persons, string author, string title)
        {
            int id = 1;
            if (persons != null && persons.Count > 0)
            {
                id = persons.Max(x => x.Id) + 1;
            }
            persons.Add(new Book { Id = id, Author = author, Title = title });
        }
    }
}