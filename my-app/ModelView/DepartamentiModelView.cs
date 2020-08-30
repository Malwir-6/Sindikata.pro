using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_app.ModelView
{
    public class DepartamentiModelView
    {
        public int Id { get; set; }
        public int SindikataId { get; set; }
        [Required]
        public string Emri { get; set; }
        public string Adresa { get; set; }
        [Required]
        public string Telefoni { get; set; }
        [Required]
        public string Emaili { get; set; }

        public DateTime? Themelimi { get; set; }
        public Sindikata Sindikata { get; set; }
    }
}
