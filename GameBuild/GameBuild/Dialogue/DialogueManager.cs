using System;
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
                            string tempS = String.Empty + line[0];

                            int i = int.Parse(tempS);
                            if (i > items.Count - 1)
                            {
                                items.Add(new List<DialogueItem>());
                            }

                            tempS = String.Empty + line[2];

                            int j = int.Parse(tempS);
                            int exitNumber = line[line.Length - 1];

                            string l = line;
                            l = l.Remove(0, 4);
                            l = l.Replace("|", System.Environment.NewLine);
                            items[i].Add(new DialogueItem(l, j, exitNumber));
                        }
                    }
                }
                catch
                {
                    throw new Exception("Failed to load dialogue.");
                }
            }
        }

        public int GetNextStatementIndex(int statement, int choice)
        {
            if (statement < items.Count - 1 && IndexIsExit(statement, 0))
            {
                return items[statement][choice].NextStatement;
            }
            return -1;
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

        public bool IndexIsExit(int statement, int index)
        {
            if (items[statement][index].ExitNumber > 0)
                return true;
            else
                return false;
        }
    }
}