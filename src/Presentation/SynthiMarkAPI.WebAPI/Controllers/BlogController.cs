using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using SynthiMarkAPI.Domain.Entities;

namespace SynthiMarkAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IBlogWriteRepository _blogWriteRepository;

        public BlogController(IBlogWriteRepository blogWriteRepository, IBlogReadRepository blogReadRepository)
        {
            _blogWriteRepository = blogWriteRepository;
            _blogReadRepository = blogReadRepository;
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            var blogs = _blogReadRepository.GetAll();

            return Ok(blogs);
        }
    }
}
