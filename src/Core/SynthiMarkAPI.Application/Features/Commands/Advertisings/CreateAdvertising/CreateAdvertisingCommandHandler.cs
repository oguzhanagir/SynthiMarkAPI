using MediatR;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Commands.Advertisings.CreateAdvertising
{
    public class CreateAdvertisingCommandHandler : IRequestHandler<CreateAdvertisingCommandRequest, CreateAdvertisingCommandResponse>
    {
        private readonly IAdvertisingWriteRepository _advertisingWriteRepository;

        public CreateAdvertisingCommandHandler(IAdvertisingWriteRepository advertisingWriteRepository)
        {
            _advertisingWriteRepository = advertisingWriteRepository;
        }

        public async Task<CreateAdvertisingCommandResponse> Handle(CreateAdvertisingCommandRequest request, CancellationToken cancellationToken)
        {
           
            await _advertisingWriteRepository.AddAsync(new()
            {
                Title = request.Title,
                Description = request.Description,
                AdvertisingType = request.AdvertisingType,
               //todo Buraya ekleme yaparken kullanıcı bilgisi verilmesi gerekiyor buradaki tasarım düzeltilmeli
            });
            await _advertisingWriteRepository.SaveAsync();

            return new();
        }
    }
}
