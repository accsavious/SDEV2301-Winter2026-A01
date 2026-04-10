using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson37DemoMauiApp.Services
{
    public interface IDiscountService
    {
        decimal ApplyDiscount(decimal originalPrice);
    }
}
