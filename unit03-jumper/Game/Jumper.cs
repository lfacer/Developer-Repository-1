using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Jumper
    {
        public string letter = "";
        public string random_word = "";


        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Jumper()
        {
            random_word = "apple";
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {

        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound()
        {
            return distance[distance.Count - 1] == 0;
        }

        /// <summary>
        /// Watches the seeker by keeping track of how far away it is.
        /// </summary>
        /// <param name="jumper">The seeker to watch.</param>
        
        public void WatchWord(Word word)
        {
            if (Word.Contains(letter))
            {
                Console.WriteLine("Found");
            }

            foreach (string letter in word)
            {
                Console.WriteLine(letter);
            }
        }

        public void CreateJumper(string[] args)
        {
            object[] array = {@"-----",@" ___ ",@"/___\",@"\   /",@" \ / ",@"  0  ",@" /|\ ",@" / \ "};
            string image = string.Join("/n", array);
        }
    }
}