using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreNeighborhood
{
    internal class NeighborhoodServices
    {
        public void CreateNeighborhood(ResedentialContext db)
        {
            if (db.Neighborhoods.Any())
                return;
            Neighborhood defaultNeighborhood = new Neighborhood
            {
                Name = "Garneau",
                District = 'P',
            };
            db.Neighborhoods.Add(defaultNeighborhood);
            db.SaveChanges();
        }

        public Neighborhood? GetOnlyNeighborhoodByName(ResedentialContext db, string name)
        {
            var namedHoodIter = db.Neighborhoods.Where(n => n.Name == name).ToList();
            return namedHoodIter.FirstOrDefault(defaultValue: null);
        }

        public void CreateHouses(ResedentialContext db, Neighborhood neighborhood)
        {
            neighborhood.Houses.AddRange(
                    new House { Address = "123 Fake Street", PostalCode = "T5B2C7", Neighborhood = neighborhood },
                     new House { Address = "555 Five Avenue", PostalCode = "T5C7Z1", Neighborhood = neighborhood },
                     new House { Address = "888 Ate Boulevard", PostalCode = "T5Q5V4", Neighborhood = neighborhood }
             );
        }

        public Neighborhood? GetNeighborhoodAndHousesByName(ResedentialContext db, string name)
        {
            var namedHoodAndHousesIter = db.Neighborhoods.Where(n => n.Name == name).Include(n => n.Houses).ToList();
            return namedHoodAndHousesIter.FirstOrDefault(defaultValue: null);
        }

        public void PrintNeighborhood(Neighborhood? neighborhood)
        {
            if (neighborhood == null)
            {
                Console.WriteLine("No such neighborhood");
                return;
            }
            Console.WriteLine($"{neighborhood.Name} District: {neighborhood.District} ID: {neighborhood.Id}");
            Console.WriteLine($"Number of houses: {neighborhood.Houses.Count()}");
            if (neighborhood.Houses.Any())
            {
                Console.WriteLine("Houses at:");
                foreach (House house in neighborhood.Houses)
                {
                    Console.WriteLine($" - {house.Address} PCode: {house.PostalCode}");
                }
            }
        }

        public House? GetHouseById(ResedentialContext db, int id)
        {
            var houseIter = db.Houses.Where(h => h.Id == id).ToList();
            return houseIter.FirstOrDefault(defaultValue: null);
        }

        public void UpdateAddress(ResedentialContext db, int houseId, string newAddress)
        {
            var houseOrNull = GetHouseById(db, houseId);
            if (houseOrNull == null) return;

            houseOrNull.Address = newAddress;
            db.SaveChanges();
        }

        public void UpdateDistrict(ResedentialContext db, Neighborhood neighborhood, char newDistrict)
        {
            if (neighborhood == null) return;

            neighborhood.District = newDistrict;
            db.SaveChanges();
        }

        public void RemoveHouseById(ResedentialContext db, int houseId)
        {
            var houseOrNull = GetHouseById(db, houseId);
            if (houseOrNull == null) return;
            houseOrNull.Address.Remove(houseId);
            db.SaveChanges();
        }

        public void RemoveNeighborhood(ResedentialContext db, Neighborhood neighborhood)
        {
            if (neighborhood == null) return;
            db.Remove(neighborhood);
            db.SaveChanges();
        }
    }
}
