using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infraestructure.Repositories;

namespace SocialMedia.API.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        //el atajo ctor para hacer el constructor
        //Inyeccion de dependencia via constructor
        public PostController(IPostRepository postRepository)
        {
            //Al _postRepository se le va asignar el postRepository que es el que le estan inyectando como dependencia
            _postRepository = postRepository;
        }

        [Route("")]
        [Route("Post")]
        [Route("Post/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Post/getPost")]
        public async Task<IActionResult> GetPost()
        {

            var posts = await _postRepository.GetPosts();

            //Retorna un status 200, todo funciono como se esperaba
            return Ok(posts);
        }
    }
}
