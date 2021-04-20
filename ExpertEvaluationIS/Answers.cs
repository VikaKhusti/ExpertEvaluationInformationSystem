using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class Answers
    {
        // public int GNumber { get; set; }
        //public int QNumber { get; set; }
        //public string Question { get; set; }
        public string Answer { get; set; }
        public int Value { get; set; }
        public bool isSelected { get; set; }

        public Answers(string answer, int value)
        {
            this.Answer = answer;
            this.Value = value;
        }
    }
}
