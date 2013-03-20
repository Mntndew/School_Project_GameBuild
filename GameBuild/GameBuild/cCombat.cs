using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace GameBuild
{
    public class cCombat
    {
        enum choices
        {
            yell,
            insult,
            slap,
            stateMother,
            stateFather,
            none,
        }
        choices currentChoice = choices.yell;
        //for the npc's choice
        Random rand = new Random();

        //0 = player's turn, 1 = npc's turn
        int turn = 0;
        bool madeMove = false;

        int playerHp, enemyHp;

        public cCombat(cNpc npc, cCharacter player)
        {
            enemyHp = npc.health;
            playerHp = player.hp;
        }

        public void Update(Game1 game, cCharacter player, cNpc npc)
        {
            player.hp = playerHp;
            npc.health = enemyHp;
            if (turn == 0 && !madeMove)
            {
                #region select attack method
                if (game.keyState.IsKeyDown(Keys.Up) && game.oldState.IsKeyUp(Keys.Up))
                {
                    if (currentChoice == choices.insult)
                    {
                        currentChoice = choices.yell;
                    }
                    if (currentChoice == choices.yell)
                    {
                        currentChoice = choices.stateFather;
                    }
                    if (currentChoice == choices.stateFather)
                    {
                        currentChoice = choices.stateMother;
                    }
                    if (currentChoice == choices.stateMother)
                    {
                        currentChoice = choices.slap;
                    }
                }
                if (game.keyState.IsKeyDown(Keys.Down) && game.oldState.IsKeyUp(Keys.Down))
                {
                    if (currentChoice == choices.yell)
                    {
                        currentChoice = choices.insult;
                    }
                    if (currentChoice == choices.stateFather)
                    {
                        currentChoice = choices.yell;
                    }
                    if (currentChoice == choices.stateMother)
                    {
                        currentChoice = choices.stateFather;
                    }
                    if (currentChoice == choices.slap)
                    {
                        currentChoice = choices.stateMother;
                    }
                }
                if (game.keyState.IsKeyDown(Keys.Enter) && game.oldState.IsKeyUp(Keys.Enter))
                {
                    
                }
                #endregion
            }
            if (turn == 1)
            {
                int choice = rand.Next(1, 5);
                if (choice == 1)
                {
                    currentChoice = choices.yell;
                }
                if (choice == 2)
                {
                    currentChoice = choices.insult;
                }
                if (choice == 3)
                {
                    currentChoice = choices.slap;
                }
                if (choice == 4)
                {
                    currentChoice = choices.stateMother;
                }
                if (choice == 5)
                {
                    currentChoice = choices.stateFather;
                }
            }
            
            
        }

        public void Yell()
        {
            if (turn == 0)
            {
                enemyHp--;
                madeMove = true;
                turn = 1;
            }
            if (turn == 1)
            {
                playerHp--;
                madeMove = true;
                turn = 0;
            }
        }
        public void Insult()
        {
            if (turn == 0)
            {
                enemyHp--;
                madeMove = true;
                turn = 1;
            }
            if (turn == 1)
            {
                playerHp--;
                madeMove = true;
                turn = 0;
            }
        }
        public void Slap()
        {
            if (turn == 0)
            {
                enemyHp--;
                madeMove = true;
                turn = 1;
            }
            if (turn == 1)
            {
                playerHp--;
                madeMove = true;
                turn = 0;
            }
        }
        public void StateMother()
        {
            if (turn == 0)
            {
                enemyHp--;
                madeMove = true;
                turn = 1;
            }
            if (turn == 1)
            {
                playerHp--;
                madeMove = true;
                turn = 0;
            }
        }
        public void StateFather()
        {
            if (turn == 0)
            {
                enemyHp--;
                madeMove = true;
                turn = 1;
            }
            if (turn == 1)
            {
                playerHp--;
                madeMove = true;
                turn = 0;
            }
        }
    }
}
