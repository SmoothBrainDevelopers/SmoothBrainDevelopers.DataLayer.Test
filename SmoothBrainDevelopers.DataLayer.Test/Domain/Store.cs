using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmoothBrainDevelopers.DataLayer.Test.Domain
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }

        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }
        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
