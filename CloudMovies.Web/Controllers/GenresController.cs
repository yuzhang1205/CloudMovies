using AutoMapper;
using CloudMovies.Entities;
using CloudMovies.Infrastructure;
using CloudMovies.Repositories;
using CloudMovies.Web.Infrastructure.Core;
using CloudMovies.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CloudMovies.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/genres")]
    public class GenresController : ApiControllerBase
    {
        private readonly IEntityBaseRepository<Genre> _genresRepository;
        public GenresController(IEntityBaseRepository<Genre> genresRepository, IEntityBaseRepository<Error> _errorsRepository,
            IUnitOfWork _unitOfWork)
            : base(_errorsRepository, _unitOfWork)
        {
            _genresRepository = genresRepository;
        }
        [AllowAnonymous]
        public HttpResponseMessage Get(HttpRequestMessage request){
            return CreatHttpReponse(request,()=>{
                HttpResponseMessage response=null;
                var genres=_genresRepository.GetAll().ToList();
                IEnumerable<GenreViewModel> genreVM=Mapper.Map<IEnumerable<Genre>,IEnumerable<GenreViewModel>>(genres);
                response=request.CreateResponse<IEnumerable<GenreViewModel>>(HttpStatusCode.OK,genreVM);
                return response;
            });
        }
    }
}