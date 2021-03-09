using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_pro.Models
{
    //This model class is for creating a page Cinema//
    public class Cinema
    {


        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
