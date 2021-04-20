using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class Qij
    {
        public int GiNumber { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public List<Answers> ansCollection { get; set; }
        //public string Question { get; set; }
        public int Mark { get; set; }

        public Qij(int GiNumber, int Number, string Name, List<Answers> ansCollection, int Mark)
        {
            this.GiNumber = GiNumber;
            this.Number = Number;
            this.Name = Name;
            this.ansCollection = ansCollection;
            //this.Question = Question;
            this.Mark = Mark;
        }
    }
}
