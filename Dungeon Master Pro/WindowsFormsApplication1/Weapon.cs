using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Weapon : Item
    {
        int attackBonus { get; set; }
        int die { get; set; }
        int numberOfDice { get; set; }
        int critMin { get; set; }
        int critMax { get; set; }
        int critMultiplier { get; set; }
        int range { get; set; }
        string type { get; set; }
        string notes { get; set; }
    }
}
