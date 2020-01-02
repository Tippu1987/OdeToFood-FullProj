using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        public int restaurantId { get; set; }
        private IRestaurantData restaurant;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData rest)
        {
            restaurant = rest;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurant.GetRestaurantById(restaurantId);
            if(Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}