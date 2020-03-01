using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PlacedOn { get; set; }
        public decimal Total { get; set; }

        public User PlacedBy { get; set; }
    }
}
