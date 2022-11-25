using Microsoft.AspNetCore.Mvc;
using ShowNew.Data.Interfaces;
using ShowNew.ViewModels;

namespace ShowNew.Controllers {
    public class CarsController : Controller {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory) {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        public ViewResult List() {
            // ViewBag.Category = "My text"; not used
            // var cars = _allCars.getAllCars;

            ViewBag.Title = "Page with automobiles";
            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.getAllCars;
            obj.currentCategory = "Auto";

            return View(obj);
        }
    }
}
