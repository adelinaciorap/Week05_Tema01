using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.School_classes
{
    public class Comment
    {
        private List<string> optionalComment;

        public Comment()
        {
            this.OptionalComment = new List<string>();
        }

        public List<string> OptionalComment { get; set; }




        public void AddComment(string optionalComment)
        {
            OptionalComment.Add(optionalComment);
        }

        public void PrintComment()
        {
            foreach (var element in OptionalComment)
            {
                Console.WriteLine("Comment: " + element);
            }
        }



    }
}
