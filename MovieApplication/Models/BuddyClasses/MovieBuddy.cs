using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{
    [MetadataType(typeof(MovieBuddy))]
    public partial class Movie
    {

    }

    sealed class MovieBuddy
    {
        public int MovieID { get; set; }

        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        public string Director { get; set; }
        public string Genre { get; set; }
    }
}