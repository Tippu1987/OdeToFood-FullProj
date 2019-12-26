using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllRestaurantsByName(string name);
        Restaurant GetRestaurantById(int Id);
        //Test checkin....
    }
}
