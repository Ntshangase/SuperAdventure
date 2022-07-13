using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
<<<<<<< HEAD
        public List<LootItem> LootTable { get; set;}
=======
>>>>>>> 53e8f127dde3ae4807a00c4a6e8d08ec7b674106

        public Monster(int id, string name, int maximumDamage,int rewardExperiencePoints,int rewardGold,int currentHitPoints,int maximumHitPoints) : base(currentHitPoints,maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
<<<<<<< HEAD
            LootTable = new List<LootItem>();
=======
>>>>>>> 53e8f127dde3ae4807a00c4a6e8d08ec7b674106
        }
    }
}