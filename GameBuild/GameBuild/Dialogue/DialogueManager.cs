using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GameBuild
{

    public delegate void ExitEventHandler(object sender, DialogueEventArgs e);

    /// <summary>
    /// Manages all lines of a dialogue
    /// Contains methods to load and send strings to the game
    /// </summary>
    public class DialogueManager
    {
        List<List<DialogueItem>> items = new List<List<DialogueItem>>(); //2d list of all the dialogue items associated with this system

        public event ExitEventHandler ReachedExit;

        protected virtual void OnReachedExit(DialogueEventArgs e)
        {
            if (ReachedExit != null)
            {
                ReachedExit(this, e);
            }
        }

        /// <summary>
        /// Class which manages several dialogue lines and provides methods to fetch different lines of dialogue. 
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
                        string[] args = line.Split(':');

                        //check for comments (length of 1 means no dots which mean no args)
                        if (args.Length == 1)
                        {
                            continue;
                        }

                        //get the index of the whole statement
                        int index = int.Parse(args[0]);
                        //add it if it doesn't exist
                        if (index > items.Count - 1)
                        {
                            items.Add(new List<DialogueItem>());
                        }
                        //get the index of the next line this one leads to
                        int nextIndex = int.Parse(args[1]);
                        //get the potential exit number
                        int exitNumber = int.Parse(args[3]);

                        //get the line
                        string l = args[2];
                        l = l.Replace('|', '\n');
                        items[index].Add(new DialogueItem(l, nextIndex, exitNumber));
                    }
                }
                catch
                {
                    throw new Exception("Failed to load dialogue: " + filepath);
                }
            }
        }

        public int GetNextStatementIndex(int statement, int choice)
        {
            if (statement < items.Count - 1 && !IndexIsExit(statement, 0))
            {
                return items[statement][choice].NextStatement;
            }
            OnReachedExit(new DialogueEventArgs(items[statement][0].ExitNumber));
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

    public class DialogueEventArgs : EventArgs
    {
        public int exitNumber;
        public DialogueEventArgs(int exitNumber)
        {
            this.exitNumber = exitNumber;
        }
    }
}