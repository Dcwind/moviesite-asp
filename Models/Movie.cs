using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SnMovie.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Movie 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
