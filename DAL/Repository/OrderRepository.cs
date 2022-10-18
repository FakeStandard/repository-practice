using repository_practice.DAL.IRepository;
using repository_practice.Models;

namespace repository_practice.DAL.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(NorthwindContext context)
            : base(context)
        { }

        public IList<Order> GetByCustomerID(int id)
        {
            var res = from r in context.Orders
                      where r.CustomerID == id.ToString()
                      select r;

            return res.ToList();
        }

        public IList<Order> GetByEmployeeID(int id)
        {
            var res = from r in context.Orders
                      where r.EmployeeID == id
                      select r;

            return res.ToList();
        }
    }
}
