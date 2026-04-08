using MauiAppLesson4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppLesson4.Services
{
    internal interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductById(int id);
    }
}
