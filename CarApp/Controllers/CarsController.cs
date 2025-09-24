using CarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarApp.Controllers
{
    public class CarsController : Controller
    {
        private static List<Car> _cars = new List<Car>
        {
            new Car { CarId = 1, CarBrand = "Toyota", CarModel = "Corolla", CarDescription = "A compact sedan with reliable fuel efficiency.", CarPrice = 850000 },
            new Car { CarId = 2, CarBrand = "Honda", CarModel = "Civic", CarDescription = "Sporty sedan known for its modern design.", CarPrice = 1200000 },
            new Car { CarId = 3, CarBrand = "Ford", CarModel = "Mustang", CarDescription = "Iconic sports car with powerful engine options.", CarPrice = 2500000 }
        };

        public ActionResult List()
        {
            return View(_cars);
        }

        public ActionResult Details(int id)
        {
            var car = _cars.FirstOrDefault(c => c.CarId == id);
            if (car == null) return HttpNotFound();
            return View(car);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

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