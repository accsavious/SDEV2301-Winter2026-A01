using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson37DemoMauiApp.Services
{
    public class SimpleDiscountService : IDiscountService
    {
        private const decimal DiscountRate = 0.10m; // 10% off

        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice * (1 - DiscountRate);
        }
    }
}
