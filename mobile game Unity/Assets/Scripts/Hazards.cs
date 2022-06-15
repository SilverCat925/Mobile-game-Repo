using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazards : MonoBehaviour
{
    // Start is called before the first frame update
    public string gameOverScene;
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        
        Collider2D objectWeCollidedWith = collisionData.collider;

        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.Kill();
            SceneManager.LoadScene(gameOverScene);
        }
    }

}
