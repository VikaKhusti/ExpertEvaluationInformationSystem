using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    class Gi
    {
        public string GName { get; set; }
        public int Number { get; set; }
        public int KCount { get; set; }
        public List<Kij> KijCollection { get; set; }
        public int Valuation { get; set; }
        public int DesirableRating { get; set; }
        public int Sum { get; set; }
    }
}
