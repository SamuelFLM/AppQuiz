using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    internal class Question
    {
        public Question()
        {
            Requests = new List<Information>();
        }

        public List<Information> Requests { get; set; }

    }
}
