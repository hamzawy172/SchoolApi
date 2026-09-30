using Microsoft.EntityFrameworkCore;
using SchoolApi.Data;
using SchoolApi.Repos.Interfaces;

namespace SchoolApi.Repos.immpelementation
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly MyContext c;
        private readonly DbSet<T> dbSet;
        public GenericRepo(MyContext c , DbSet<T> set)
        {
            this.c = c;
            dbSet = set;
        }
        public void Add(T Entity)
        {
           dbSet.Add(Entity);
        }

        public void Delete(int id)
        {
            var data = dbSet.Find(id);
            dbSet.Remove(data);
        }

        public List<T> GetAll()
        {
           return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T Entity)
        {
            dbSet.Update(Entity);
        }
    }
}
