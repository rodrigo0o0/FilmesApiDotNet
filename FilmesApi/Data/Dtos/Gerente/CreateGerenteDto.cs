using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateGerenteDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Nome { get; set; }

    }
}
