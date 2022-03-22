using Microsoft.AspNetCore.Mvc;
using SocialMedia.Infraestructure.Repositories;

namespace SocialMedia.API.Controllers
{
    public class PostController : Controller
    {
        [Route("")]
        [Route("Post")]
        [Route("Post/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Post/Hola")]
        public IActionResult GetPost()
        {

            var posts = new PostRepository().GetPosts();

            //Retorna un status 200, todo funciono como se esperaba
            return Ok(posts);
        }
    }
}
