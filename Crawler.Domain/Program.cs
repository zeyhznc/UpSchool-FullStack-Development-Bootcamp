using Domain.Entities;
using Domain.Enums;

// API isteği
var order = new Order()
{
    Id = Guid.NewGuid(),
    RequestedAmount = 50,
    ProdcutCrawlType = ProductCrawlType.All
};


// Bir Order verildiğinde onun Event'i olması lazım. Çünkü bot, orderEvent'i gönderdikten sonra işleme başlayacak
var orderEvent = new OrderEvent()
{
    Id = Guid.NewGuid(),
    OrderId = order.Id,
    CreatedOn = DateTimeOffset.Now,
    Status = OrderStatus.BotStarted
};


// Orderlar tek tek kaydedilecek
order.OrderEvent = new List<OrderEvent>();
order.OrderEvent.Add(orderEvent);
