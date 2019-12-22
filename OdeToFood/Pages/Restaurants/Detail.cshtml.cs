using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int restaurantId { get; set; }
        private IRestaurantData restaurant;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData rest)
        {
            restaurant = rest;
        }
        public void OnGet()
        {
            Restaurant = restaurant.GetRestaurantById(restaurantId);
        }
    }
}