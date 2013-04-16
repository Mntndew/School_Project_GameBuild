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
        int exitNumber;
        public string Line { get { return line; } } //String to represent a statement/answer option/question of a dialogue
        public int NextStatement { get { return nextStatement; } } //Index of the next set of lines (if its 0 this is the question)
        public int ExitNumber { get { return exitNumber; } } //0 = not exit, anything else specifies a specific exit

        public DialogueItem(string line, int nextStatement, int exitNumber)
        {
            this.line = line;
            this.nextStatement = nextStatement;
            this.exitNumber = exitNumber;
        }
    }
}
