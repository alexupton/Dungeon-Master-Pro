using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Armor : Item
    {
        string type { get; set; }
        int acBonus { get; set; }
        int maxDex { get; set; }
        int checkPenalty { get; set; }
        int spellFail { get; set; }
        int speed { get; set; }
        List<string> sepcProperties { get; set; }
    }
}
