﻿using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Infraestructure.Repositories
{
    //El repositorio va a implementar la interfaz IPostRepository
    public class PostRepository : IPostRepository
    {

        //Retorna un listado de publicaciones asincrono osea en un Task
        //Esto para cumplir el contrato que se asigno en IPostRepository
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://misapis.com/{x}",
                UserId = x * 2
            });

            await Task.Delay(10);
            return posts;
        }
    }
}
