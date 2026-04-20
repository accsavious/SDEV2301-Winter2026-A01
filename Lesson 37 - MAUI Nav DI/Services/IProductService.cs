using Lesson37DemoMauiApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson37DemoMauiApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductById(int id);
    }
}
