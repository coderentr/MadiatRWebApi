using MadiatoRDemoWebApi.Models.Entities;

namespace MadiatoRDemoWebApi.Common
{
    public class FakeStorage
    {
        private static List<Product> _products;
        public FakeStorage()
        {
            _products = new List<Product>
            {
            new Product { Id = 1, Name = "Test Product 1" },
            new Product { Id = 2, Name = "Test Product 2" },
            new Product { Id = 3, Name = "Test Product 3" }
            };
        }
        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_products);
        }
        public async Task<Product> GetProductById(int id)
        {
            return await Task.FromResult(_products.Single(p => p.Id == id));
        }
    }
}
