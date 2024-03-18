using websidebanhang.Models;

namespace websidebanhang.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
