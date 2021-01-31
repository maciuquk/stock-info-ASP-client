using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockInfoASPClient.Models
{
    [Table("occurence")]
    public partial class Occurence
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Wydarzenie")]
        public string Event { get; set; }
        [Display(Name ="Url")]
        [DataType(DataType.Url)]
        public string Url { get; set; }
    }
}
