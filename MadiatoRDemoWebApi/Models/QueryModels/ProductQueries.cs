using MadiatoRDemoWebApi.Models.Entities;
using MediatR;

namespace MadiatoRDemoWebApi.Models.QueryModels
{
    public class ProductQueries
    {
        public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
        public record AddProductCommand(Product Product) : IRequest;
        public record GetProductByIdQuery(int Id) : IRequest<Product>;
    }
}
