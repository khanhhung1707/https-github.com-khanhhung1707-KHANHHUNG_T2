namespace websidebanhang.Repositories
{
    using System.Collections.Generic;
    using websidebanhang.Models;
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
