using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Domain;

[TestClass]
public class OrderTests
{
    [TestMethod]
    [TestCategory("Domain")]
    public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracteres()
    {
        var customer = new Customer("Daniel Martins", "daniel@dev.io");
        var order = new Order(customer, 0, null);
        Assert.AreEqual(8, order.Number.Length);
    }
}