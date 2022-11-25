using ShowNew.Data.Models;
using System.Collections.Generic;

namespace ShowNew.Data.Interfaces {
    public interface ICarsCategory {
        IEnumerable<Category> getAllCategories { get; }
    }
}
