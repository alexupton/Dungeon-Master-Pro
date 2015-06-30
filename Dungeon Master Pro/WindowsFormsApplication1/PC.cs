using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PC
    {
        //Basic Properties
        string name { get; set; }
        string player { get; set; }
        CharClass cClass { get; set; }
        Race race { get; set; }
        string alignment { get; set; }
        string diety { get; set; }
        string size { get; set; }
        int age { get; set; }
        char gender { get; set; }
        int height { get; set; }
        int weight { get; set; }
        string eyeColor { get; set; }
        string hairColor { get; set; }
        string skinColor { get; set; }
        List<string> languages { get; set; }
        string campaign { get; set; }


        //Vitals
        int MaxHP { get; set; }
        int currentHP { get; set; }
        int AC { get; set; }
        int touchAC { get; set; }
        int flatFootedAC { get; set; }
        int nonLethalDamage { get; set; }
        int speed { get; set; }
        int initiative { get; set; }
        int XP { get; set; }

        //Abilities
        Ability str { get; set; }
        Ability dex { get; set; }
        Ability con { get; set; }
        Ability intelligence { get; set; }
        Ability wis { get; set; }
        Ability cha { get; set; }

        //Saving Throws
        int fort { get; set; }
        int reflex { get; set; }
        int will { get; set; }

        //attacks
        int baseAttackBonus { get; set; }
        List<int> additionalAttacks { get; set; }
        int grappleMod { get; set; }

        //Equipment
        List<Weapon> weapons { get; set; }
        Armor armor { get; set; }
        Armor shield { get; set; }
        List<Armor> protectiveItems { get; set; }
        List<Item> otherPossessions { get; set; }
        int lightLoad { get; set; }
        int medLoad { get; set; }
        int heavyLoad { get; set; }

        //Money
        int CP { get; set; }
        int SP { get; set; }
        int GP { get; set; }
        int PP { get; set; }

        //Skills, feats, and special abilities
        List<Skill> skills { get; set; }
        List<Feat> feats { get; set; }
        List<SpecialAbility> specials { get; set; }

        //Magic
        int maxspellPoints { get; set; }
        int currentSpellPoints { get; set; }
        int maxLvlLearnable { get; set; }
        int maxLvlCreatable { get; set; }
        int bardMusicUses { get; set; } //for bards only
        List<Spell> knownSpells { get; set; }
        int spellFailure { get; set; }

        //Misc
        bool isLiterate { get; set; }




    }
}
