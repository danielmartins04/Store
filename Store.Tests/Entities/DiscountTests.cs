using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Tests.Helper;

namespace Store.Tests.Entities;

[TestClass]
public class DiscountTests : BaseTests
{
    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_desconto_expirado_o_valor_do_pedido_deve_ser_60() 
    {
        var expiredDiscount = new Discount(10, DateTime.Now.AddDays(-5)); // 0
        var order = new Order(_customer, 0, expiredDiscount);
        order.AddItem(_product, 6); // valor do pedido = 60
        Assert.AreEqual(order.Total(), 60);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_desconto_invalido_o_valor_do_pedido_deve_ser_60() 
    {
        var order = new Order(_customer, 0, null);
        order.AddItem(_product, 6); // valor do pedido = 60
        Assert.AreEqual(order.Total(), 60);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_desconto_de_10_o_valor_do_pedido_deve_ser_60() 
    {
        var order = new Order(_customer, 0, _discount); // - 10 de desconto + 0 de entrega = -10
        order.AddItem(_product, 6); // valor do pedido = 60 - 10 de desconto = 50
        Assert.AreEqual(order.Total(), 50);
    }
}