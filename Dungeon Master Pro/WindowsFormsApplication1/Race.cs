using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Race
    {
        string name { get; set; }
        char size { get; set; }
        List<string> autoLanguages { get; set; }
        List<string> bonusLanguages { get; set; }
        CharClass favoredClass { get; set; }
        int speed { get; set; }
        int[] racialAbilityModifiers{get; set;}
    }
}
