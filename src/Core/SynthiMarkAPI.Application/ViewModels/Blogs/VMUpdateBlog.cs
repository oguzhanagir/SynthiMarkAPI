using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.ViewModels.Blogs
{
    public class VMUpdateBlog
    {
        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public User User { get; set; }
    }
}
