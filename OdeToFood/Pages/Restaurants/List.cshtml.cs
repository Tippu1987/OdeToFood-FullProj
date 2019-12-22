using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        private IRestaurantData restaurantData { get; set; }
        private IConfiguration iConfig { get; set; }
        public List<Restaurant> RestaurantList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }
        

        public ListModel(IRestaurantData rest, IConfiguration ic)
        {
            restaurantData = rest;
            iConfig = ic;
        }
        public void OnGet()
        {
            RestaurantList = restaurantData.GetAllRestaurantsByName(searchTerm).ToList();
            Message = iConfig.GetValue<string>("ConfigMessage");
        }


    }
}
