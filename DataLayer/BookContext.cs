using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class BookContext : IDB<Book, string>
    {
        private practicheski_izpit_3Context ctx;

        public BookContext()
        {
            ctx = new practicheski_izpit_3Context();
        }
        public void Create(Book item)
        {
            try
            {
                ctx.Books.Add(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Book Read(string key)
        {
            try
            {
                return ctx.Books.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Book> ReadAll()
        {
            try
            {
                return ctx.Books.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Book item)
        {
            try
            {
                Book a = Read(item.ID);
                ctx.Entry(a).CurrentValues.SetValues(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                Book item = Read(key);
                ctx.Books.Remove(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
