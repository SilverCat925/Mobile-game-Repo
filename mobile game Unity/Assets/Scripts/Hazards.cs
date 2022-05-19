using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        PlayerHealth healthScript = collision.gameObject.GetComponent<PlayerHealth>();
        healthScript.Kill();

        if (healthScript != null)
        { 
            healthScript.Kill();
        }
    }
}
