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
        public string user_input = "";
        public string random_word = "";


        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Jumper()
        {
            random_word = "apple";
            user_input = "";
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            string hint = "";
            foreach (var user_input in random_word)

            if(random_word.Contains(user_input)) 
            {
                hint += $" {user_input} ";
            }
            else
            {
                hint += " _ ";
            }

            return hint;

        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound()
        {
            return true;
        }


        public object CreateJumper()
        {
            List<string> list1 = new List<string>();
            list1.Add(@" ----- ");
            list1.Add(@"  ___  ");
            list1.Add(@" /___\ ");
            list1.Add(@" \   / ");
            list1.Add(@"  \ /  ");
            list1.Add(@"   0   ");
            list1.Add(@"  /|\  ");
            list1.Add(@"  / \  ");

            Console.WriteLine(list1);
            int counter = 0;
    
            if(random_word.Contains(user_input))
            {
                Console.WriteLine(list1);
                return list1;
            }

            else
            {
                while (counter < 7) 
                {
                    list1.RemoveAt(counter);
                    counter =+ 1;
                    Console.WriteLine(list1);
                }  
            }

            return list1;
        }
    }
}