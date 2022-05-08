using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using AutoMapper;


namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {

        public EnderecoProfile(){
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
