using MosEngTest.Data;
using MosEngTest.Data.Entities;

namespace MosEngTest.Repositories
{
    public class TodosRepository
    {
        public bool Create(Todo model)
        {
            try
            {
                using (var c = new MainDbContext())
                {
                    c.Todos.Add(model);
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