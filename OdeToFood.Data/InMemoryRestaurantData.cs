using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { CuisineType =CuisineType.Chinese, Id=1,Name="PF Changs",Location="Chandler,AZ"},
                new Restaurant { CuisineType = CuisineType.Italian, Id = 2, Name = "Papa Murphy's Pizza", Location = "Seattle, WA" },
                new Restaurant { CuisineType = CuisineType.Indian, Id = 3, Name = "Hyderabad House", Location = "San Francisco, CA" },
                new Restaurant { CuisineType = CuisineType.Thai, Id = 4, Name = "Totts Asian Diner", Location = "New York, NY" },
                new Restaurant { CuisineType = CuisineType.Vietnamese, Id = 5, Name = "Turk Dish", Location = "Austin, TX" }
            };
        }
        public IEnumerable<Restaurant> GetAllRestaurantsByName(string name = "")
        {
            return (from r in restaurants
                    where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                    orderby r.Name
                    select r);
        }

        public Restaurant GetRestaurantById(int Id)
        {
            return restaurants.SingleOrDefault(x => x.Id == Id);
        }
    }
}
