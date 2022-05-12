using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We need this in order to access the Text component
// since it is part of the UI
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Public variables
    // Editable in Unity. accessable by other scripts
    public Text scoreDisplay;
    public bool resetScore = false;

    // Private variables
    // Can't be seen in Unity or accessed by other scripts
    private static int scoreValue;


    // Unity calls this function on the first frame after this object is created
    void Start()
    {
        // If we have requested the score to be reset for this scene.... (condition)
        if (resetScore)
        {
            // Reset the score to 0! (action)
            scoreValue = 0;
        }

        // Then, update the display of the score based on the numerical value
        scoreDisplay.text = scoreValue.ToString();
    }


    // Function to add to the player's score
    // NOT automatically called by Unity, we need to call it ourselves in our code
    public void AddScore(int toAdd)
    {
        // First, update the numerical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        // Then, update the display of the score based on the numerical value (Action 2)
        scoreDisplay.text = scoreValue.ToString();
    }
}
