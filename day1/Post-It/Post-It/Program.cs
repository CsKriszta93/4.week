using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Post_It
{
    public struct Postit
    {
        public string BackgroundColor;
        public string Text;
        public string TextColor;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Postit postit1 = new Postit();
            postit1.BackgroundColor = "orange";
            postit1.TextColor = "blue";
            postit1.Text = "Idea 1";

            Postit postit2 = new Postit();
            postit2.BackgroundColor = "pink";
            postit2.TextColor = "black";
            postit2.Text = "awesome";

            Postit postit3 = new Postit();
            postit3.BackgroundColor = "yellow";
            postit3.TextColor = "green";
            postit3.Text = "Superb";
        }
    }
}
