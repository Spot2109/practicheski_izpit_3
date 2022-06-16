using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
     public class practicheski_izpit_3Context: DbContext
    {
        public practicheski_izpit_3Context()
        {
        }

        public practicheski_izpit_3Context(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=BooksDB;Uid=root;Pwd=sptz2109#;");
            }
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }
        
        public DbSet<Author> Authors { get; set; }
    }
}
