using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{
    [MetadataType(typeof(RentalBuddy))]
    public partial class Rental
    {

    }

    sealed class RentalBuddy
    {
        [Display(Name = "Rental Date")]
        public System.DateTime DateRented { get; set; }
    }
}