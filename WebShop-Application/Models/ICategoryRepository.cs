using System.Collections.Generic;

namespace WebShop_Application.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
