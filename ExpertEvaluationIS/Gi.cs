using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    public class Gi
    {
        public string GName { get; set; }   //numb of Criteion
        public int Number { get; set; }       
        public List<Qij> QijCollection { get; set; }
        //public int Valuation { get; set; }
        public int DesirableRating { get; set; }
        public int Sum { get; set; }

        public Gi(string GName, int Number, List<Qij> QijCollection)
        {
            this.GName = GName;
            this.Number = Number;
            this.QijCollection = QijCollection;
            //this.Valuation = Valuation;
            //this.DesirableRating = DesirableRating;
        }
    }
}
