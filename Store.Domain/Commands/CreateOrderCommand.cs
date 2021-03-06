using Flunt.Notifications;
using Flunt.Validations;
using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands;

public class CreateOrderCommand : Notifiable, ICommand
{
    public CreateOrderCommand()
    {
        Items = new List<CreateOrderItemCommand>();
    }

    public CreateOrderCommand(string customer, string zipcode, string promoCode, IList<CreateOrderItemCommand> items)
    {
        Customer = customer;
        Zipcode = zipcode;
        PromoCode = promoCode;
        Items = items;
    }

    public string Customer { get; set; }
    public string Zipcode { get; set; }
    public string PromoCode { get; set; }
    public IList<CreateOrderItemCommand> Items { get; set; }

    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()
            .HasLen(Customer, 11, "Customer", "Cliente inválido.")
            .HasLen(Zipcode, 8, "Zipcode", "CEP inválido")
        );
    }
}