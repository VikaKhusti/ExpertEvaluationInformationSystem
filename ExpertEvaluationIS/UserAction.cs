using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    class UserAction
    {
        public bool? AutomaticInput { get; set; }
        public bool? ManualInput { get; set; }

        public UserAction(bool? automaticInput, bool? manualInput)
        {
            this.AutomaticInput = automaticInput;
            this.ManualInput = manualInput;
        }
    }
}
