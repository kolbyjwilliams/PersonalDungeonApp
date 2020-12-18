using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Charater
    {
        private int _life;

        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxLife { get; set; }
        public int HitChance { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (Life <= MaxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else
            }//end set
        }//end int life

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

    }//end class
}//end namespace
