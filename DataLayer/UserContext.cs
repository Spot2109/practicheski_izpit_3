using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserContext : IDB<User, string>
    {
        private practicheski_izpit_3Context ctx;

        public UserContext()
        {
            ctx = new practicheski_izpit_3Context();
        }
        public void Create(User item)
        {
            try
            {
                ctx.Users.Add(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Read(string key)
        {
            try
            {
                return ctx.Users.Find(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> ReadAll()
        {
            try
            {
                return ctx.Users.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(User item)
        {
            try
            {
                User a = Read(item.ID);
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
                User item = Read(key);
                ctx.Users.Remove(item);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    
    }
}
