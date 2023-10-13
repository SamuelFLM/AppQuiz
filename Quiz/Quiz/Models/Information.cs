using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    internal class Information
    {

        public Information() { }
        public Information(string title, List<string> options, string result, string image)
        {
            Title = title;
            Options = options;
            Result = result;
            Image = image;
        }

        public string Title { get; private set; }

        public List<string> Options { get; private set; }
        public string Result { get; private set; }

        public string Image { get; private set; }
    }
}
