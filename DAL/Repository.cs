using Microsoft.EntityFrameworkCore;

namespace repository_practice.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal readonly NorthwindContext context;
        internal readonly DbSet<T> dbSet;

        public Repository(NorthwindContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public T GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            Delete(GetByID(id));
        }

        protected void Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);

            dbSet.Remove(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
