using MediatR;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Commands.Advertisings.RemoveAdvertising
{
    public class RemoveAdvertisingCommandHandler : IRequestHandler<RemoveAdvertisingCommandRequest, RemoveAdvertisingCommandResponse>
    {
        private readonly IAdvertisingWriteRepository _advertisingWriteRepository;
        private readonly IAdvertisingReadRepository _advertisingReadRepository;
        public RemoveAdvertisingCommandHandler(IAdvertisingWriteRepository advertisingWriteRepository, IAdvertisingReadRepository advertisingReadRepository)
        {
            _advertisingWriteRepository = advertisingWriteRepository;
            _advertisingReadRepository = advertisingReadRepository;
        }

        public async Task<RemoveAdvertisingCommandResponse> Handle(RemoveAdvertisingCommandRequest request, CancellationToken cancellationToken)
        {
            var advertising = await _advertisingReadRepository.GetByIdAsync(Guid.NewGuid(),request.Id);

            if (advertising != null)
            {
                _advertisingWriteRepository.Remove(advertising);
                await _advertisingWriteRepository.SaveAsync();

            }

            return new();
        }
    }
}
