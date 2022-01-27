using MadiatoRDemoWebApi.Common;
using MadiatoRDemoWebApi.Models.Entities;
using MediatR;
using static MadiatoRDemoWebApi.Models.QueryModels.ProductQueries;

namespace MadiatoRDemoWebApi.Handlers.ProductHandlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeStorage _fakeStore;
        public GetProductsHandler(FakeStorage fakeStore) => _fakeStore = fakeStore;
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
            CancellationToken cancellationToken) =>
            await _fakeStore.GetAllProducts();
    }
}
