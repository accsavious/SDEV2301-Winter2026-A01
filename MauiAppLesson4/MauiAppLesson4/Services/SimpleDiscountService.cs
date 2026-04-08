using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppLesson4.Services
{
    internal class SimpleDiscountService : IDiscountServices
    {
        private const decimal DiscountRate = 0.1m;
        public decimal ApplyDiscount(decimal originalPrice)
        {
            return originalPrice * (1 - DiscountRate);
        }
    }
}
