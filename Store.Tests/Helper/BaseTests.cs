using System;
using Store.Domain.Entities;

namespace Store.Tests.Helper;

public class BaseTests
{
    protected readonly Customer _customer = new Customer("Daniel Martins", "daniel@dev.io");
    protected readonly Product _product = new Product("Monitor", 10, true);
    protected readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(5));
}