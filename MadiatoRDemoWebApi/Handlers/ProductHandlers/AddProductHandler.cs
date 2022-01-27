using MadiatoRDemoWebApi.Common;
using MediatR;
using static MadiatoRDemoWebApi.Models.QueryModels.ProductQueries;

namespace MadiatoRDemoWebApi.Handlers.ProductHandlers
{
    public class AddProductHandler: IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeStorage _fakeDataStore;
        public AddProductHandler(FakeStorage fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddProduct(request.Product);
            return Unit.Value;
        }
    }
}
