using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    public class eyeFly : Enemy
    {
        public eyeFly() : base()
        {
            //setting default values
            this.nmeHealthPoints = 85;
            this.nmeClassName = "NGTV Eye Fly";
            this.nmexpValue = 20;
            this.nmeData = "The staple Drone has followed you to record your data and analyze your movements - \n you're no lab rat! Take it out!";
        }
    }
}
