using MadiatoRDemoWebApi.Common;
using MadiatoRDemoWebApi.Models.Entities;
using MediatR;
using static MadiatoRDemoWebApi.Models.QueryModels.ProductQueries;

namespace MadiatoRDemoWebApi.Handlers.ProductHandlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeStorage _fakeStore;
        public GetProductByIdHandler(FakeStorage fakeStore) => _fakeStore = fakeStore;
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
        await _fakeStore.GetProductById(request.Id);
    }
}
