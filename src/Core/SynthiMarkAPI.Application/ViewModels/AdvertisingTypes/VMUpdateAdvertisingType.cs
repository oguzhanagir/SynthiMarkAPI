using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.ViewModels.AdvertisingTypes
{
    public class VMUpdateAdvertisingType
    {
        public string Name { get; set; }

        public ICollection<Advertising> Advertisings { get; set; }
    }
}
