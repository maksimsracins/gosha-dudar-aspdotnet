using ShowNew.Data.Models;
using System.Collections.Generic;

namespace ShowNew.ViewModels {
    public class CarsListViewModel {

        public IEnumerable<Car> getAllCars { get; set; }
        public string currentCategory { get; set; }
    }
}
