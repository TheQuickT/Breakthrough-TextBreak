using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    //set class to public
    //creating enemy class to act as base for enemies
    public class Enemy
    {
        //Variables/String along with Protected
        protected int nmeHealthPoints;
        protected string nmeClassName;
        protected int nmexpValue;
        protected string nmeData;

        //create the basic constructor
        public Enemy()
        {

        }

        //create a HUD method for the npc base class
        public void NMEHUD()
        {
            //print var values
            Console.WriteLine("Enemy Type: {0}", this.nmeClassName);
            Console.WriteLine("Enemy HP: " + this.nmeHealthPoints);
            Console.WriteLine("Enemy Data Entry:" + this.nmeData); 
        }

        //create a public property to get the npc health point value
        public int GetNMEHealthPoints
        {
            get { return this.nmeHealthPoints; }
        }

        //create a public property to set the npc healthpoint value
        public int SetNMEHealthPoints
        {
            set { this.nmeHealthPoints = value; }
        }

        //create a public property to read npc class
        public string GetNMEClassName
        {
            get { return this.nmeClassName; }
        }

        //create a public property to read npc npcxpValue
        public int GetNMEXP
        {
            get { return this.GetNMEXP; }
        }

        //Gather Enemy Data Entry to be read
        public string getnmeData
        {
            get { return this.nmeData;  }
        }

    }
}
