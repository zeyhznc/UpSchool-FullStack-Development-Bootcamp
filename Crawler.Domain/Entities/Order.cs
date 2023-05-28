using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public int RequestedAmount { get; set; } //kazınmak istenen ürün sayısı

        public int TotalAmount { get; set; } // kazıdığımız ürün miktarı      

        public ProductCrawlType ProdcutCrawlType { get; set; }

        public ICollection<OrderEvent> OrderEvent { get; set; } //

        public ICollection<Product> Products { get; set; } // Her siparişin birden fazla Product'ı olabilir

        public DateTimeOffset CreatedOn { get; set; }
    }
}
