using Coffe.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.dto
{
    internal class OrderCreateDTO
    {
        public string CustomerName { get; set; } = "";
        public List<Drink> Drinks { get; set; } = new();
    }
}
