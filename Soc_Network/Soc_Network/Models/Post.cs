using System.ComponentModel.DataAnnotations;

namespace Soc_Network.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string User { get; set; }

        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
