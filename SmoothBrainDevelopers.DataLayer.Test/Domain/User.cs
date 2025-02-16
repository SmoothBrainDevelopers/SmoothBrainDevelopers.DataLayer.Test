using System.ComponentModel.DataAnnotations;

namespace SmoothBrainDevelopers.DataLayer.Test.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
}
