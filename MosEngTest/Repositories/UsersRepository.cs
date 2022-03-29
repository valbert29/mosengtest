using System.Linq;
using MosEngTest.Data;
using MosEngTest.Data.Entities;

namespace MosEngTest.Repositories
{
    public class UsersRepository
    {
        public bool Create(User model)
        {
            try
            {
                using (var c = new MainDbContext())
                {
                    c.Users.Add(model);
                    c.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public User GetById(int id)
        {
            try
            {
                using (var c = new MainDbContext())
                {
                    var user = c.Users
                        .SingleOrDefault(x => x.Id == id);
                    if (user != null) 
                        user.Todos = c.Todos.Where(x => x.UserId == user.Id).ToList();
                    return user;
                }
            }
            catch
            {
                return default;
            }
        }
        
        public bool Delete(int id)
        {
            try
            {
                using (var c = new MainDbContext())
                {
                    var user = c.Users.SingleOrDefault(x => x.Id == id);
                    if (user == null)
                    {
                        return false;
                    }
                    
                    c.Users.Remove(user);
                    c.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}