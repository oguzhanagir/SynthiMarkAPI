using SynthiMarkAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Domain.Entities
{
    public class Video : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TagList { get; set; }

        public User User { get; set; }
    }
}
