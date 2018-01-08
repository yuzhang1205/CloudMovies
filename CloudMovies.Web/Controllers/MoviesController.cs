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
    [Authorize(Roles="Admin")]
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiControllerBase
    {
        //private readonly IEntityBaseRepository<Movie> _moviesRepository;
        //private readonly IEntityBaseRepository<Rental> _rentalsRepository;
        //private readonly IEntityBaseRepository<Stock> _stocksRepository;
        //private readonly IEntityBaseRepository<Customer> _customersRepository;

        //public MoviesController(IEntityBaseRepository<Movie> moviesRepository,IEntityBaseRepository<Rental> rentalsRepository,
        //    IEntityBaseRepository<Stock> stocksRepository,IEntityBaseRepository<Customer> customersRepository,
        //    IEntityBaseRepository<Error> _errorsRepository,IUnitOfWork _unitOfWork):base(_errorsRepository,_unitOfWork)
        //{
        //    _moviesRepository = moviesRepository;
        //    _rentalsRepository = rentalsRepository;
        //    _stocksRepository = stocksRepository;
        //    _customersRepository = customersRepository;
        //}
        private readonly IEntityBaseRepository<Movie> _moviesRepository;
        //private readonly IEntityBaseRepository<Rental> _rentalsRepository;
        //private readonly IEntityBaseRepository<Stock> _stocksRepository;
        //private readonly IEntityBaseRepository<Customer> _customersRepository;

        public MoviesController(IEntityBaseRepository<Movie> moviesRepository,
            IEntityBaseRepository<Error> _errorsRepository, IUnitOfWork _unitOfWork)
            : base(_errorsRepository, _unitOfWork)
        {
            _moviesRepository = moviesRepository;
            //_rentalsRepository = rentalsRepository;
            //_stocksRepository = stocksRepository;
            //_customersRepository = customersRepository;
        }
        [AllowAnonymous]
        [Route("latest")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreatHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;
                var movies = _moviesRepository.GetAll().OrderByDescending(m => m.ReleaseDate).Take(6).ToList();
                IEnumerable<MovieViewModel> movieVM = Mapper.Map<IEnumerable<Movie>, IEnumerable<MovieViewModel>>(movies);
                response = request.CreateResponse<IEnumerable<MovieViewModel>>(HttpStatusCode.OK, movieVM);
                return response;
            });
        }
    }
}
