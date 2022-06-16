using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class AuthorContext : IDB<Author, string>
    {
        private practicheski_izpit_3Context ctx;

        public AuthorContext()
        {
            ctx = new practicheski_izpit_3Context();
        }
        public void Create(Author item)
        {
            try
            {
                ctx.Authors.Add(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Author Read(string key)
        {
            try
            {
                return ctx.Authors.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Author> ReadAll()
        {
            try
            {
                return ctx.Authors.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Author item)
        {
            try
            {
                Author a = Read(item.ID);
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
                Author item = Read(key);
                ctx.Authors.Remove(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
