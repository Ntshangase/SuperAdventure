using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
<<<<<<< HEAD
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player (int currentHitPoints,int maximumHitPoints,int gold,int experiencePoints,int level) 
            : base(currentHitPoints,maximumHitPoints)
=======
        public int Level { get; set; } 

        public Player (int currentHitPoints,int maximumHitPoints,int gold,int experiencePoints,int level) : base(currentHitPoints,maximumHitPoints)
>>>>>>> 53e8f127dde3ae4807a00c4a6e8d08ec7b674106
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
<<<<<<< HEAD
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
=======
>>>>>>> 53e8f127dde3ae4807a00c4a6e8d08ec7b674106
        }
    }
}
