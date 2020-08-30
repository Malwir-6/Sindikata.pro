using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Departamenti
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Sindikata")]
        public int SindikataId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Emri { get; set; }
        public string Adresa { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Telefoni { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Emaili { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Themelimi { get; set; }
        public Sindikata Sindikata { get; set; }
    }
}
