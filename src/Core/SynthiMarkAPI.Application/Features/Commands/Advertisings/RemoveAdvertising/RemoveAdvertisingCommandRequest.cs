using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Commands.Advertisings.RemoveAdvertising
{
    public class RemoveAdvertisingCommandRequest : IRequest<RemoveAdvertisingCommandResponse>
    {
        public string Id { get; set; }
    }
}
