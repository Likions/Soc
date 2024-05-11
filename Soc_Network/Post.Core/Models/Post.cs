using System.ComponentModel.DataAnnotations;

namespace PostStorage.Core.Models
{
    public class Post
    {
        private Post(Guid id, string user, string message)
        {
            Id = id;
            User = user;
            Message = message;
            //CreatedDate = createdDate;
        }

        public Guid Id { get; }
        public string User { get; }
       
        public string Message { get; }
        //[DataType(DataType.Date)]
        //public DateTime CreatedDate { get; set; }


        public static (Post post, string error) Create(Guid id, string user, string message)
        {
            var error = string.Empty;
            if (string.IsNullOrEmpty(message))
            {
                error = "Post don't be empty!";
            }
            var post = new Post(id, user, message);
            return(post,error);
        }
    }
}
