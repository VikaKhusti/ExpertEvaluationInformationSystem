using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class G
    {
        public int Count { get; set; }
        public int QCount { get; set; }
        public List<Gi> GiCollection { get; set; }

        public G() { }

        public G(int Count, int QCount) { this.Count = Count; this.QCount = QCount; }

    }
 
}
