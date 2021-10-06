using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCPerson.Models
{
    public class PersonNTA264
    {

        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage="Please enter product name.")]
         [Display(Name = "Tên")]
        public string PersonName { get; set; }

    }
    
}