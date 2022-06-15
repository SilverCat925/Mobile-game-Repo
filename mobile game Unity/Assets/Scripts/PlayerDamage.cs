using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // CONDITION: When the projectile hits a certain object type... (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Check if the object we collided with has the tag we are looking for (Enemy)
        if (otherCollider.CompareTag("Enemy") == true)
        {
            // Perform our action
            KillEnemy(otherCollider.gameObject);
        }
    }


    // ACTION: Destroy an object (enemy)
    public void KillEnemy(GameObject enemy)
    {
        // Check if the enemy has the "ScoreKill" component
        ScoreKill scoreKillScript = enemy.GetComponent<ScoreKill>();
        if (scoreKillScript != null)
        {
            // Get the player's score script so we can add to their score
            Score playerScore = FindObjectOfType<Score>();

            // Add the value from the scoreKillScript
            playerScore.AddScore(scoreKillScript.killValue);
        }

        // Destroy the enemy
        Destroy(enemy);

    }
}
