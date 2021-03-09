using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_pro.Models
{
    public class Movie
    {

       //This model class is creating page Movies//

            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Genre { get; set; }

            [Required]
            public string Director { get; set; }

            [Required]
            public string Producer { get; set; }
        }
}
