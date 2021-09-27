using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        //The Movie class contains an Id field,
        //which is required by the database for the primary key.
        public int Id { get; set; }
        public string Title { get; set; }

        //Only the date is displayed, not time information
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
