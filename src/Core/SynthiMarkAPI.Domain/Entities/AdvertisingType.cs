using SynthiMarkAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Domain.Entities
{
    public class AdvertisingType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Advertising> Advertisings { get; set; }
    }
}
