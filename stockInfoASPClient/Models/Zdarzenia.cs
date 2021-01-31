using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockInfoASPClient.Models
{
    [Table("Zdarzenia", Schema = "dbo")]
    public partial class Zdarzenia
    {
        [Key]
        public int Id { get; set; }
        public string Tresc { get; set; }
        public string Url { get; set; }
    }
}
