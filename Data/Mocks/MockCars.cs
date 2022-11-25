using ShowNew.Data.Interfaces;
using ShowNew.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShowNew.Data.Mocks {
    public class MockCars : IAllCars {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> getAllCars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla",
                        shortDesc = "Электричка",
                        longDesc = "Долгони зарядку. У тебя айфон, андроид или тесла?",
                        img = "/img/tesla-modelx.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.getAllCategories.First()
                    },
                    new Car {
                        name = "Opel Astra",
                        shortDesc = "Норм машина, хороша собой",
                        longDesc = "Баранка крутится, лапша мутится",
                        img = "/img/opel-astra.png",
                        price = 5000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.getAllCategories.ElementAt(1)
                    },
                    new Car {
                        name = "Volvo S40",
                        shortDesc = "Забей, говно а не машина",
                        longDesc = "Не трать на неё время",
                        img = "/img/volvo-s40.png",
                        price = 4000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.getAllCategories.ElementAt(1)
                    }
                };
            }
        }
        public IEnumerable<Car> getFavouriteCars { get; set; }
       

        public Car getCarById(int id) {

            return null;
        }

    }
}
