using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    // Start is called before the first frame update
    public string gameStartScene;

    public void StartGameButton()
    {
        SceneManager.LoadScene(gameStartScene);

    }



}
