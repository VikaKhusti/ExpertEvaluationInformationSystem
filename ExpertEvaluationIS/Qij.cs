using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class Qij
    {
        public int GiNumber { get; set; }
        public int Number { get; set; }
        public string Question { get; set; }
        public int Mark { get; set; }

        public Qij(int GiNumber, int Number, string Question, int Mark)
        {
            this.GiNumber = GiNumber;
            this.Number = Number;
            this.Question = Question;
            this.Mark = Mark;
        }
    }
}
