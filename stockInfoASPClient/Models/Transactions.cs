using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockInfoASPClient.Models
{
    public partial class Transactions
    {
        [Key]
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string BuyPrice { get; set; }
        public int BuyQuantity { get; set; }
        public string SellPrice { get; set; }
        public int SellQuantity { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Companies.Transactions))]
        public virtual Companies Company { get; set; }
    }
}
