using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DOS.Models
{
    public class Rehber
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]

        public string Name { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50)]

        public string City { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100)]

        public string Address { get; set; }
    }
}