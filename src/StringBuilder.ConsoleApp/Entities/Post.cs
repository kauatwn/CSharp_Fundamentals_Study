using System.Text;

// Devido a um conflito de nomes, o namespace original foi alterado
//namespace StringBuilder.ConsoleApp.Entities
namespace ConsoleApp.Entities
{
    internal class Post(DateTime moment, string title, string content, int likes)
    {
        public DateTime Moment { get; set; } = moment;
        public string Title { get; set; } = title;
        public string Content { get; set; } = content;
        public int Likes { get; set; } = likes;
        public List<Comment> Comments { get; set; } = [];

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} Likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"{Content}");
            sb.AppendLine("Comments:");

            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
