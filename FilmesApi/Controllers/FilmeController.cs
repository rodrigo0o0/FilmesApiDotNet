using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;
        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id;
            id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return filmes;
        }
    }
}
