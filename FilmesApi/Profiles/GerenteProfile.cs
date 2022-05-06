using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinemas, opts => opts
                .MapFrom(gerente => gerente.Cinemas.Select
                (cinema => new { cinema.Id, cinema.Nome, cinema.Endereco, cinema.EnderecoId }))); // serve para resolve o loop infinito e definir oque eu quero mostra de cinemas em gerente
        }
    }
}
