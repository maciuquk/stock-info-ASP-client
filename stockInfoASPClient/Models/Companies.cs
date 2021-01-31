using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockInfoASPClient.Models
{
    public partial class Companies
    {
        public Companies()
        {
            Transactions = new HashSet<Transactions>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("Company")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
