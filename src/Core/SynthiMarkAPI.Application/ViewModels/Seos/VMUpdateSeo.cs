using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.ViewModels.Seos
{
    public class VMUpdateSeo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorInfo { get; set; }
        public User User { get; set; }
    }
}
