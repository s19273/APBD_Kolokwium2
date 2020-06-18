using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2_s19273.DTO.Request
{
    public class AddPlayerReq
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int NumOnShirt { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
