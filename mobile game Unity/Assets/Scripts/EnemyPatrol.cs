using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float forceStrength;
    public Vector2[] patrolPoints;
    public float stopDistance;

    private Rigidbody2D ourRigidbody;
    private int currentPoint = 0;

    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        if (distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;

            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;

            }

        }
        Vector2 direction = patrolPoints[currentPoint] - (Vector2)transform.position;
        direction = direction.normalized;

        ourRigidbody.AddForce(direction * forceStrength);
    }
}
