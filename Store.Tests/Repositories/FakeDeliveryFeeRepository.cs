using Store.Domain.Repositories.Interfaces;

namespace Store.Domain.Repositories;

public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
{
    public decimal Get(string zipCode)
    {
        return 10;
    }
}