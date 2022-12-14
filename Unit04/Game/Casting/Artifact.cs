using System.Collections.Generic;
using System.IO;
using System;

namespace unit04_greed.Game.Casting
{
  
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Artifact:Actor{
        private int score = 0;
    
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact(){

        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public int GetScore(){
            
            return score;

        }
        
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetScore(int score){
            this.score = score;

        }
    }
}