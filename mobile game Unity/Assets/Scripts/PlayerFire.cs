using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Unity editor variable
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;

    // KEYBOARD / GAMEPAD ONLY!
    // CONDITION: When the player presses a key / button...
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
        }
    }

    // ACTION: Fire a projectile
    public void FireProjectile()
    {
        // Clone the pojectile
        // Declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        // Position the projectile on the player
        clonedProjectile.transform.position = transform.position; // OPTIONAL: Add an offset (use a public variable)

        // Fire it in a direction
        // Declare a vairable to hold the cloned object's rigidbody
        Rigidbody2D projectileRigidbody;
        // Get the rigidbody from our cloned projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        // Set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity;

        // Play firing animation
        // Declare a variable to hold the animation on our player
        Animator playerAnimator;
        // Get the animation already attached to our player so we can use it
        playerAnimator = GetComponent<Animator>();
        // Use the animator component to trigger an animation change for attacking
        playerAnimator.SetTrigger("attack");
    }
}
