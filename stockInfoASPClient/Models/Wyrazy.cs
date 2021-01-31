using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockInfoASPClient.Models
{
    [Table("Wyrazy", Schema = "dbo")]
    public partial class Wyrazy
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Wpisz frazę")]
        [StringLength(10)]
        public string Wyraz { get; set; }
    }
}
