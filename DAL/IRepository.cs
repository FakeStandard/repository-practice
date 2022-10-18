namespace repository_practice.DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetByID(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        void Save();
    }
}
