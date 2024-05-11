using System.ComponentModel.DataAnnotations;

namespace SocNetCurs.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string? User { get; set; }
        public string? Message { get; set; }
    }
}
