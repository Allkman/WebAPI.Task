using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task.Data.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        public User User { get; set; }
        public int Retries { get; set; }


    }
}
