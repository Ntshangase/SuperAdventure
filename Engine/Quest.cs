using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
<<<<<<< HEAD
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
=======
>>>>>>> 53e8f127dde3ae4807a00c4a6e8d08ec7b674106

        public Quest (int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
<<<<<<< HEAD
            QuestCompletionItems = new List<QuestCompletionItem>();
=======
>>>>>>> 53e8f127dde3ae4807a00c4a6e8d08ec7b674106
        }
    }
}