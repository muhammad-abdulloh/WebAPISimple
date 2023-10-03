using WebAPISimple.Models;

namespace WebAPISimple.Repositoy
{
    public interface IProductRepository
    {
        public ValueTask<IEnumerable<Product>> GetAllAsync();

        public Product Get(int id);

        public Product Add(Product item);

        public void Remove(int id);

        public bool Update(Product item);
    }
}
