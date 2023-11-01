using MediatR;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Commands.Advertisings.UpdateAdvertising
{
    public class UpdateAdvertisingCommandHandler : IRequestHandler<UpdateAdvertisingCommandRequest, UpdateAdvertisingCommandResponse>
    {
        private readonly IAdvertisingWriteRepository _advertisingWriteRepository;
        private readonly IAdvertisingReadRepository _advertisingReadRepository;

        public UpdateAdvertisingCommandHandler(IAdvertisingWriteRepository advertisingWriteRepository, IAdvertisingReadRepository advertisingReadRepository)
        {
            _advertisingWriteRepository = advertisingWriteRepository;
            _advertisingReadRepository = advertisingReadRepository;
        }

        public async Task<UpdateAdvertisingCommandResponse> Handle(UpdateAdvertisingCommandRequest request, CancellationToken cancellationToken)
        {
            var advertising = await _advertisingReadRepository.GetByIdAsync(Guid.NewGuid(),request.Id);

            if (advertising !=null)
            {
                advertising.Title = request.Title;
                advertising.Description = request.Description;

                _advertisingWriteRepository.Update(advertising);
                await _advertisingWriteRepository.SaveAsync();
            }

            return new();

        }
    }
}
