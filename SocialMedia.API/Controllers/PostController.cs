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
            //var posts = new PostRepository().GetPosts();
            //La linea anterior es mala practica debido a que se crea una instancia nueva, aumentando asi el nivel de acoplamiento de clases
            //Básicamente, el acoplamiento de clases es una medida de cuántas clases usa una sola clase
            var posts = await _postRepository.GetPosts();

            //Retorna un status 200, todo funciono como se esperaba
            return Ok(posts);
        }
    }
}
