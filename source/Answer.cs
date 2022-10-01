using System;
using System.Collections.Generic;

namespace SystemOfWeaponts
{
    [Serializable]
    public class Answer
    {
        public int ID { get; private set; }
        public int QuestID {get; private set;}
        public string Text { get; private set; }
        public List<double> Effects { get; private set; }

        public Answer(int id, int questID, string text, List<double> effects)
        {
            ID = id;
            QuestID = questID;
            Text = text;
            Effects = effects;
        }

        public void Enter(Weaponts weaponts)
        {
            for (int i = 0; i < weaponts.weaps.Count; i++)
            {
                weaponts.weaps[i].ChangeProbability(Effects[i]);
            }
        }
    }
}
