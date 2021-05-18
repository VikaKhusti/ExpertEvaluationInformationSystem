using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class G 
    {
        public int Count { get; set; }                  //count of Criterion
        public int QCount { get; set; }                 //count of Questions, by default = 4
        public List<Gi> GiCollection { get; set; }      //collection of Criterion   

        public G() { }

        public G(int Count, int QCount) { this.Count = Count; this.QCount = QCount; }
        public G(int Count, int QCount, List<Gi> GiCollection) { this.Count = Count; this.QCount = QCount; this.GiCollection = GiCollection; }

    }
 
}
