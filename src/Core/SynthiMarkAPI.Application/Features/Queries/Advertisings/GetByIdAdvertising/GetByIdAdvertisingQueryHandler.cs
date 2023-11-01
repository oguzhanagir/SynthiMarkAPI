using MediatR;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using SynthiMarkAPI.Domain.Entities;

namespace SynthiMarkAPI.Application.Features.Queries.Advertisings.GetByIdAdvertising
{
    public class GetByIdAdvertisingQueryHandler : IRequestHandler<GetByIdAdvertisingQueryRequest, GetByIdAdvertisingQueryResponse>
    {
        private readonly IAdvertisingReadRepository _advertisingReadRepository;

        public GetByIdAdvertisingQueryHandler(IAdvertisingReadRepository advertisingReadRepository)
        {
            _advertisingReadRepository = advertisingReadRepository;
        }

        public async Task<GetByIdAdvertisingQueryResponse> Handle(GetByIdAdvertisingQueryRequest request, CancellationToken cancellationToken)
        {
            Advertising advertising =  await _advertisingReadRepository.GetByIdAsync(Guid.NewGuid(),request.Id);


            return new()
            {
                Title = advertising.Title,
                Description = advertising.Description,
                AdvertisingType = advertising.AdvertisingType
            };
            
        }
    }
}
