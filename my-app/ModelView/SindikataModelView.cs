using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_app.ModelView
{
    public class SindikataModelView
    {
        public int Id { get; set; }
        [Required]
        public string Emri { get; set; }
        public string Adresa { get; set; }
        [Required]
        public string Emaili { get; set; }
        public string Zip { get; set; }
        public DateTime? Themelimi { get; set; }
    }
}
