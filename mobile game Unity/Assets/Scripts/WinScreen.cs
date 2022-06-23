using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public string gameWinScene;
    void OnCollisionEnter2D(Collision2D collisionData)
    {

        Collider2D objectWeCollidedWith = collisionData.collider;

        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        if (player != null)
        {
            SceneManager.LoadScene(gameWinScene);
        }
    }
}
