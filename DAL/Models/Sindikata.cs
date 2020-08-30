using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Sindikata
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Emri { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Adresa { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Emaili { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Zip { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Themelimi { get; set; }

        public ICollection<Departamenti> Departamentis { get; set; }
    }
}
