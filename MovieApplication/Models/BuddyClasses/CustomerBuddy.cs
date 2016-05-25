using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{
    [MetadataType(typeof(CustomerBuddy))]
    public partial class Customer
    {
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }

    sealed class CustomerBuddy
    {
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
    }
}