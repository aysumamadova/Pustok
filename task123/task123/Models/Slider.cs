using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace task123.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Desc { get; set; }
        public string RedirectUrl { get; set; }
        public string RedirectUrlText { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }

    }
}
