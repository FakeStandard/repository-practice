using repository_practice.Models;

namespace repository_practice.DAL.IRepository
{
    public interface IOrderRepository : IRepository<Order>
    {
        IList<Order> GetByCustomerID(int id);
        IList<Order> GetByEmployeeID(int id);
    }
}
