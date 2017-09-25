using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    public class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;

    }
    class Program
    {
        static void Main(string[] args)
        {
            var blogpost = new BlogPost();
            blogpost.AuthorName = "John Doe";
            blogpost.Title = "Lorem Ipsum";
            blogpost.Text = "Lorem ipsum dolor sit amet.";
            blogpost.PublicationDate = "2000.05.04.";

            var blogpost2 = new BlogPost();
            blogpost2.AuthorName = "Tim Urban";
            blogpost2.Title = "Wait but why";
            blogpost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogpost2.PublicationDate = "2010.10.10.";

            var blogpost3 = new BlogPost();
            blogpost3.AuthorName = "William Turton";
            blogpost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogpost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, " +
                "doesn’t want to be the center of attention. " +
                "When I asked to take his picture outside one of IBM’s New York City offices, " +
                "he told me that he wasn’t really into the whole organizer profile thing.";
            blogpost3.PublicationDate = "2017.03.28.";
        }
    }
}
