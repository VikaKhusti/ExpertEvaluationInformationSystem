using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class Groups
    {
        public int Count { get; set; }
        public List<G> GCollection { get; set; }

        public Groups(int Count)
        {
            this.Count = Count;
        }
    }
}
