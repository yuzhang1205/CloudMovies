using CloudMovies.Web.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CloudMovies.Web.Infrastructure.Validators
{
    public class MovieViewModelValidator:AbstractValidator<MovieViewModel>
    {
        public MovieViewModelValidator(){

            RuleFor(movie => movie.GenreId).GreaterThan(0).WithMessage("Select a Genre");
            RuleFor(movie => movie.Director).NotEmpty().Length(1, 100).WithMessage("Select a Director");
            RuleFor(movie => movie.Writer).NotEmpty().Length(1, 50).WithMessage("select a write");
            RuleFor(movie => movie.Producer).NotEmpty().Length(1, 50).WithMessage("Select a producer");
            RuleFor(movie=>movie.Description).NotEmpty().WithMessage("Select a Desciotian");
            RuleFor(movie=>movie.Rating).InclusiveBetween((byte)0,(byte)5).WithMessage("Rating must be less than or equal to 5");
            RuleFor(movie=>movie.TrailerURI).NotEmpty().Must(ValidTranilerURI).WithMessage("Only Youtube Trailers are supported");
        }
        private bool ValidTranilerURI(string trailerRTI){
            return (!string.IsNullOrWhiteSpace(trailerRTI)&&trailerRTI.ToLower().StartsWith("http://www.youtube.com/watch?"));
        }
    }
}