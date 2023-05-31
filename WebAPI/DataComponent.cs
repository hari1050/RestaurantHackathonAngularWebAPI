
namespace RestaurantAngular.Models
{
    public class DataComponents
    {
        AngularDB context = new AngularDB();
        public bool AddRestaurant(Restaurant Restaurant)
        {
            var empList = context.Restaurants.ToList();
            try
            {
                empList.Add(Restaurant);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }



        }



        public bool DeleteRestaurant(int id)
        {
            var empList = context.Restaurants.ToList();
            try
            {
                var emp = context.Restaurants.FirstOrDefault(e => e.id == id);
                if (emp != null)
                {
                    empList.Remove(emp);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public void UpdateRestaurant(Restaurant Restaurant)
        {
            var empList = context.Restaurants.ToList();
            var foundUpdate = context.Restaurants.FirstOrDefault(e => e.id == Restaurant.id);
            if (foundUpdate != null)
            {
                context.Remove(foundUpdate);
                context.Add(Restaurant);
                context.SaveChanges();
            }

        }



        public List<Restaurant> Show()
        {
            return context.Restaurants.ToList();
        }



    }
}