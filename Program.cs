using System;
using System.Linq;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine($"Database path: {db.DbPath}.");
                /*
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                db.Add(new Blog { Url = "http://blogs.msdn.com" });
                db.SaveChanges();
                */

                var blogs = db.Blogs.OrderBy(b => b.BlogId).ToList();
                blogs.ForEach(b => Console.WriteLine($"Id:{b.BlogId} Url:{b.Url}"));
            }
        }
    }
}