using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NguyenTheAnh0264.Models
{
    public class NTA0264
    {

        [Key]
        public int NTAId { get; set; }
         [Display(Name = "Tên")]
        public string NTAName { get; set; }
        public string NTAGender { get; set; }
        [Display(Name = "Giới Tính")]
    }
}