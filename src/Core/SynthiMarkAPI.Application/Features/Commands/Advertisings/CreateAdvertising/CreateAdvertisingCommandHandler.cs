using MediatR;
using SynthiMarkAPI.Application.Abstractions.Hubs;
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
        private readonly IAdvertisingHubService _advertisingHubService;
        public CreateAdvertisingCommandHandler(IAdvertisingWriteRepository advertisingWriteRepository, IAdvertisingHubService advertisingHubService)
        {
            _advertisingWriteRepository = advertisingWriteRepository;
            _advertisingHubService = advertisingHubService;
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

            await _advertisingHubService.AdvertisingAddedMessageAsync($"{request.Title} isminde reklam eklenmiştir.");

            return new();
        }
    }
}
