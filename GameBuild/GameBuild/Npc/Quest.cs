using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBuild.Npc
{
    public class Quest
    {
        //just simple get item quest thingy
        public string item;
        public string npcName;

        public bool accepted;
        public bool completed;

        public Quest(string item, string npcName)
        {
            this.item = item;
            this.npcName = npcName;
        }

        public void Accept(Npc npc)
        {
            accepted = true;
            //for (int i = 0; i < game.activeNpcs.Count; i++)
            {
                if (npc.name == npcName)
                {
                    if (Game1.character.HasItem(item))
                    {
                        npc.dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + npc.thirdDialogue + ".txt");
                    }
                    else
                        npc.dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + npc.secondDialogue + ".txt");
                }
            }
        }

        public void Return(Game1 game)
        {
            for (int i = 0; i < game.activeNpcs.Count; i++)
            {
                if (game.activeNpcs[i].name == npcName)
                {
                    game.activeNpcs[i].dialogue.dialogueManager = new DialogueManager(@"Content\npc\dialogue\" + game.activeNpcs[i].thirdDialogue + ".txt");
                    Game1.character.inventory.RemoveItem(item);
                }
            }
        }
    }
}