using RestaurantAngular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace ForAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly DataComponents comp;
        public RestaurantController(DataComponents comp)
        {
            this.comp = comp;
        }





        [Route("allRestaurants")]
        public List<Restaurant> GetAllRestaurants() => comp.Show();







        [HttpPut]
        public void PutRestaurant(Restaurant Restaurant) => comp.UpdateRestaurant(Restaurant);





        [HttpPost]
        public bool PostRestaurant(Restaurant Restaurant) => comp.AddRestaurant(Restaurant);





        [HttpDelete]
        public bool DeleteRestaurant(int id) => comp.DeleteRestaurant(id);
    }
}