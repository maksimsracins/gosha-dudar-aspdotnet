using ShowNew.Data.Interfaces;
using ShowNew.Data.Models;
using System.Collections.Generic;

namespace ShowNew.Data.Mocks {
    public class MockCategory : ICarsCategory {
        public IEnumerable<Category> getAllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Electro", desc = "" },
                    new Category { categoryName = "Disel", desc = "" },
                    new Category { categoryName = "Gasoline", desc = "" } };
                }
            }
        }
    }