using CarApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CarApp.Controllers
{
    public class CarsController : Controller
    {
        private static List<Car> _cars = new List<Car>
{
            new Car { CarId = 1, CarBrand = "Toyota", CarModel = "Corolla", CarDescription = "A compact sedan with reliable fuel efficiency.", CarPrice = 850000 },
            new Car { CarId = 2, CarBrand = "Honda", CarModel = "Civic", CarDescription = "Sporty sedan known for its modern design.", CarPrice = 1200000 },
            new Car { CarId = 3, CarBrand = "Ford", CarModel = "Mustang", CarDescription = "Iconic sports car with powerful engine performance.", CarPrice = 2500000 },
            new Car { CarId = 4, CarBrand = "Nissan", CarModel = "Altima", CarDescription = "Midsize sedan with a sleek comfortable ride.", CarPrice = 1500000 },
            new Car { CarId = 5, CarBrand = "BMW", CarModel = "X5", CarDescription = "Luxury SUV with cutting-edge technology.", CarPrice = 3800000 },
            new Car { CarId = 6, CarBrand = "Chevrolet", CarModel = "Silverado", CarDescription = "Full-size pickup truck with a robust build.", CarPrice = 2700000 },
            new Car { CarId = 7, CarBrand = "Mercedes", CarModel = "Benz E-Class", CarDescription = "Elegant sedan with premium features and style.", CarPrice = 2800000 },
            new Car { CarId = 8, CarBrand = "Audi", CarModel = "A6", CarDescription = "Sedan with a blend of performance and luxury.", CarPrice = 2900000 },
            new Car { CarId = 9, CarBrand = "Hyundai", CarModel = "Tucson", CarDescription = "Compact SUV offering excellent value for money.", CarPrice = 1150000 },
            new Car { CarId = 10, CarBrand = "Kia", CarModel = "Sorento", CarDescription = "Versatile SUV with a spacious interior.", CarPrice = 1450000 }
};
        public ActionResult List()
        {
            return View(_cars);
        }

        // GET: Add a car
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // POST: Add a car
        [HttpPost]
        public ActionResult Add(Car car)
        {
            if (ModelState.IsValid)
            {
                car.CarId = _cars.Count + 1;
                _cars.Add(car);
                return RedirectToAction("List");
            }
            return View(car);
        }
    }
}