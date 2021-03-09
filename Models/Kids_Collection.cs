using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_pro.Models
{
    public class Kids_Collection
    {

        //This model class is creating page Kida collection//

            public int Id { get; set; }

            [Required]
            public string Name { get; set; }



            [Required]
            public string Director { get; set; }

            [Required]
            public string Producer { get; set; }
        }
}
