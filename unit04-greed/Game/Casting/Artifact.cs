namespace Unit04.Game.Casting
{
    // TODO: Implement the Artifact class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Actor class.

        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a score about itself.
        /// </para>
        /// </summary>
    public class Artifact : Actor
    {
        private int score = 0;

    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {
        }

    // 3) Create the GetScore() method. Use the following method comment.
        
        /// <summary>
        /// Gets the artifact's score.
        /// </summary>
        /// <returns>The score as a int.</returns>
        public int GetScore()
        {
            return score;
        }
        

    // 4) Create the SetScore(int score) method. Use the following method comment.
        
        /// <summary>
        /// Sets the artifact's score to the given value.
        /// </summary>
        /// <param name="score">The given score.</param>
        public void SetScore(int score)
        {
            this.score = score;
        }
    }
    
}