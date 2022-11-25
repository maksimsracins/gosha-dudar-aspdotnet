using ShowNew.Data.Models;
using System.Collections.Generic;

namespace ShowNew.Data.Interfaces {
    public interface IAllCars {
        IEnumerable<Car> getAllCars { get;}
        IEnumerable<Car> getFavouriteCars { get; set; }
        Car getCarById(int id);
    }
}
