using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    // Public variables
    // Editable in Unity. accessable by other scripts
    public int pickupValue = 1;


    // Called by Unity when this object overlaps with another object
    // This is our Condition
    void OnTriggerEnter2D(Collider2D other)
    {
        // Get the Score script attached to the other object
        // (if it doesn't have one, scoreScript will be null)
        Score scoreScript = other.GetComponent<Score>();

        // Check if we actually found a Score script on the other object
        if (scoreScript != null)
        {
            // We have a scorescript, so the thing we bumped into is the player!

            // We should add to their score now:
            scoreScript.AddScore(pickupValue);

            // Then we should delete this object, so we don't add again next frame!
            Destroy(gameObject);
        }
    }
}
