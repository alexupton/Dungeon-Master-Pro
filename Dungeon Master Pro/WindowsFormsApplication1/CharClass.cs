using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     class CharClass
    {
        string name { get; set; }
        string description { get; set; }
        List<string> disallowedAlignments { get; set; }
        int hitDie { get; set; }
        int firstLevelSKillPoints { get; set; }
        int generalSkilPoinits { get; set; }


        List<int> babByLevel { get; set; } //base attack bonus. index = level - 1
        List<int> secAtkBonus { get; set; }
        List<int> thrdAtkBonus { get; set; }
        List<int> frthAtkBonus { get; set; }
        List<List<int>> addlAtkBonuses { get; set; }

        //level at which additional attacks become available
        int secAtkStartLvl { get; set; }
        int thrdAtkStartLvl { get; set; }
        int frthAtkStartLvl { get; set; }
        List<int> addlAtkStartLvl { get; set; }

        List<int> fortSave { get; set; }
        List<int> refSave { get; set; }
        List<int> willSave { get; set; }
        List<SpecialAbility> specials { get; set; }

        List<int> spellPoints { get; set; }
        List<int> maxSpLvlLearnable { get; set; }
        List<int> maxSplLvlCreateable { get; set; }


        }
}
