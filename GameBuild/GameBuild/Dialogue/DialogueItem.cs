using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameBuild
{
    /// <summary>
    /// Keeps information of a line in a dialogue
    /// </summary>
    class DialogueItem
    {
        string line;
        int nextStatement;
        bool isExit;
        public string Line { get { return line; } } //String to represent a statement/answer option/question of a dialogue
        public int NextStatement { get { return nextStatement; } } //Index of the next set of lines (if its 0 this is the question)
        public bool IsExit { get { return isExit; } } // Shows if this statement will exit the dialogue

        public DialogueItem(string line, int nextStatement, bool isExit)
        {
            this.line = line;
            this.nextStatement = nextStatement;
            this.isExit = isExit;
        }
    }
}
