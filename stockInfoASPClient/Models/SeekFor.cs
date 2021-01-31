using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockInfoASPClient.Models
{
    [Table("seekFor")]
    public partial class SeekFor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Wpisz prawidłową frazę")]
        public string Word { get; set; }
    }
}
