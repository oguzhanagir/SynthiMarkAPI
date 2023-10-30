using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.ViewModels
{
    public class VMCreatePostIdea
    {
        public string Content { get; set; }
        public User User { get; set; }
    }
}
