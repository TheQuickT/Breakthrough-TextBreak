using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    //setting Four to a Public Class
    public class RAPT4
    {
        //Creating Variables
        public string fourName;
        public int HP;
        public int xp;
        public int dmg;
        public int Elec;

        public RAPT4(string _RAPT4)
        {
            //default values
            this.fourName = ("RAPT-4");
            this.HP = 150;
            this.xp = 0;
            this.dmg = 25;
            this.Elec = 50;
        }

        public void HUD()
        {
            Console.WriteLine("You Still Are: {0}", this.fourName);
            Console.WriteLine("HeathPoints: {0}", this.HP);
            Console.WriteLine("XP: {0}\n", this.xp);
        }

        //create a Physical Strike method
        public int Slash()
        {
            return this.dmg;
        }

        //Creating int for Four's Electric Damage Value
        public int ElecStrike

        //now creating an Eletric Damage method
        {
            get { return this.ElecStrike; }
        }

        //Allow Four to Gain EXP
        public void GainXP(int _xpValue)
        {
            this.xp += _xpValue;

            //this.xp = (this.xp + _xpValue);
        }
    }
}
