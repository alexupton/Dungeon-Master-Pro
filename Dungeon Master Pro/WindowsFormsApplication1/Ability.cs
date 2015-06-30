using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Ability
    {
        
        public int modifier { get; private set; }
        public int score
        {
            get;
            set;
        }

        public Ability()
        {
            score = 0;
            modifier = 0;
        }

        public void SetScore(int value)
        {
            score = value;
            modifier = ((score / 2) - 5);
            
        }

    }
}
