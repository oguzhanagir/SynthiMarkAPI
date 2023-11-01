using MediatR;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Queries.Advertisings.GetAllAdvertising
{
    public class GetAllAdvertisingByUserQueryHandler : IRequestHandler<GetAllAdvertisingByUserQueryRequest, GetAllAdvertisingByUserQueryResponse>
    {
        private readonly IAdvertisingReadRepository _advertisingReadRepository;

        public GetAllAdvertisingByUserQueryHandler(IAdvertisingReadRepository advertisingReadRepository)
        {
            _advertisingReadRepository = advertisingReadRepository;
        }

        public async Task<GetAllAdvertisingByUserQueryResponse> Handle(GetAllAdvertisingByUserQueryRequest request, CancellationToken cancellationToken)
        {
            var advertisings = _advertisingReadRepository.GetAll(Guid.NewGuid(),false);

            return new GetAllAdvertisingByUserQueryResponse()
            {
                Advertisings = advertisings,
            };
        }
    }
}
