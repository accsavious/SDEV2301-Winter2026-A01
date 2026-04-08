using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppLesson4.Services
{
    internal interface IDiscountServices
    {
        decimal ApplyDiscount(decimal originalPrice);
    }
}
