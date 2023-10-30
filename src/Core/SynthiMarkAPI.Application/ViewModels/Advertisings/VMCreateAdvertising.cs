using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.ViewModels.Advertisings
{
    public class VMCreateAdvertising
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public AdvertisingType AdvertisingType { get; set; }

        public User User { get; set; }
    }
}
