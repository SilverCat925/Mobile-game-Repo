// HelloWorld
// by Josh A Agnew
// 10/3/2022

//-------------------------------------------------------
//libraries used
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------------------------

public class HelloWorld : MonoBehaviour
{

    public string message = "";
    //--------------------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(message);
    }
    //--------------------------------------------------

    //--------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        Debug.LogError("MeoM");
    }
    //--------------------------------------------------
}
/// Closing bracket
///------------------------------------------------------------------------