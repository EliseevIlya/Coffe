using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.entity
{
    internal class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public List<Drink> Drinks { get; set; } = new();
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
