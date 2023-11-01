using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Features.Queries.Advertisings.GetByIdAdvertising
{
    public class GetByIdAdvertisingQueryRequest : IRequest<GetByIdAdvertisingQueryResponse>
    {
        public string Id { get; set; }
    }
}
