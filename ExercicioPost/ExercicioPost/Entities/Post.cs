using System.Text;
using Course.Entities;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        //Relação '1 para Muitos'
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

        }

        /* Por padrão, classes que possuem relação '1 para Muitos', mesmo que não especificados,
         considera-se incluir os métodos 'Add' and 'Remove' da 'List<list>' implementada nos atributos
        dessa classe.
        Configurando a relação 1 (Classe Post) para Muitos (Classe Commment)     
         */

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("  Likes - ");
            sb.AppendLine(Moment.ToString("dd/HH/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
