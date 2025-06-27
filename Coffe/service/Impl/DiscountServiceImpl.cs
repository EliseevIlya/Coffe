using Coffe.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service.Impl
{
    internal class DiscountServiceImpl : IDiscountService
    {
        public double ApplyDiscount(double amount, DateTime time)
        {
            TimeOfDay timeOfDay = time.Hour switch
            {
                >= 6 and < 12 => TimeOfDay.Morning,
                >= 12 and < 18 => TimeOfDay.Afternoon,
                >= 18 and < 23 => TimeOfDay.Evening,
                _ => TimeOfDay.Night
            };

            return timeOfDay switch
            {
                TimeOfDay.Morning => amount * 0.9,     // 10% утренняя скидка
                TimeOfDay.Evening => amount * 0.95,    // 5% вечерняя
                _ => amount
            };
        }
    }
}
