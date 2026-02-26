using System;
using System.Collections.Generic;
using System.Text;

namespace TupleGuardRails
{
    public class FruitService
    {
        // Returns an IEnumerable of Tuples that contain the Name and Price of the fruits
        public IEnumerable<(string Name, double Price)> ProjectForListView(
            IEnumerable<Fruit> fruits)
        {
            // Guard rail, Throw a null exception if the IEnumerable<Fruit> is null.
            ArgumentNullException.ThrowIfNull(fruits);

            // Return the tuples with the name and price of the fruits.
            return fruits.Select(f => (f.Name, f.Price)).ToList();
        }
    }
}
