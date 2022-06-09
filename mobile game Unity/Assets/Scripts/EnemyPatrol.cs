using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // varibul
    public float forceStrength;
    public Vector2 patrolPoint;

    private Rigidbody2D ourRigidbody;
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = patrolPoint - (Vector2)transform.position;
        direction = direction.normalized;

        ourRigidbody.AddForce(direction * forceStrength);
    }
}
