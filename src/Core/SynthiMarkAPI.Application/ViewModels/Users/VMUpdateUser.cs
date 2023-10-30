using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.ViewModels.Users
{
    public class VMUpdateUser
    {
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Advertising> Advertisings { get; set; }
        public ICollection<PostIdeas> PostIdeas { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
