using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary
{
    public class BooksContext : DbContext //inherit from DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) //constructor 
            : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
