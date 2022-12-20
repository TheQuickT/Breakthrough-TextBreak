using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    //creating Sentry Child Class, setting to public access
    public class Sentry : Enemy
    {
        public Sentry() : base()
        {
            //setting default values
            this.nmeHealthPoints = 85;
            this.nmeClassName = "NGTV Sentry";
            this.nmexpValue = 35;
            this.nmeData = "This guardsman machine has come along to the digital world with you\n to take you out.";
        }


    }
}
