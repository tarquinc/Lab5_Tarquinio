using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;
using System.Collections.Generic;

namespace Lab5_Tarquinio.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}
