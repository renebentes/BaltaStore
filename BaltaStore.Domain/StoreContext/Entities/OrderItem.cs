using BaltaStore.Shared.Models;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;

            if (product.QuantityOnHand < quantity)
                AddNotification(nameof(Quantity), "Produto fora de estoque");

            product.DecreaseQuantity(quantity);
        }

        public decimal Price { get; private set; }

        public Product Product { get; private set; }

        public decimal Quantity { get; private set; }
    }
}