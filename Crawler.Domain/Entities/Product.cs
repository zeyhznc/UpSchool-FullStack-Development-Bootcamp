using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; } // Her Order'ın en az bir tane Prodcut'ı olabilir
        
        public Order Order { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public bool IsOnSale { get; set; }

        public decimal Price { get; set; }

        public decimal SalePrice { get; set;}

    }
}
