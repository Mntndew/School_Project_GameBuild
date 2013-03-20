﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GameBuild
{
    /// <summary>
    /// Manages all lines of a dialogue
    /// Contains methods to load and send strings to the game
    /// </summary>
    public class DialogueManager
    {
        List<List<DialogueItem>> items = new List<List<DialogueItem>>(); //2d list of all the dialogue items associated with this system

        /// <summary>
        /// 
        /// </summary>
        /// <param name= filepath"The filepath of the text file that contains the dialogue for this object"></param>
        public DialogueManager(string filepath)
        {
            using (StreamReader s = new StreamReader(filepath))
            {
                try
                {
                    string line;
                    while ((line = s.ReadLine()) != null)
                    {
                        if (line[0] != '/' && line[1] != '/')
                        {
                            items.Add(new List<DialogueItem>());
                            
                            string tempS = String.Empty + line[0];
                            
                            int i = int.Parse(tempS);
                            
                            tempS = String.Empty + line[2];

                            int j = int.Parse(tempS);

                            string l = line;
                            l = l.Remove(0, 4); 
                            items[i].Add(new DialogueItem(l, j));
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Derp broke retard l2code");
                }
            }
        }

        public void DisplayAllStrings()
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items[i].Count; j++)
                {
                    Console.WriteLine(items[i][j].Line);
                    Console.WriteLine(items[i][j].NextStatement);
                }
            }
        }

        public string[] GetDialogueLinesFromIndex(int index)
        {
            string[] s = new string[items[index].Count];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = items[index][i].Line;
            }
            return s;
        }
    }
}