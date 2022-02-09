using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Domain.Repositories;


public class FakeOrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        
    }
}