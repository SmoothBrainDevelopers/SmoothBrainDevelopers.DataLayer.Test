using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmoothBrainDevelopers.DataLayer.Test.Domain
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
