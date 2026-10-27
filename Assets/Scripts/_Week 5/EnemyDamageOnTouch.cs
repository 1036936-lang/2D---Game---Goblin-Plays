using UnityEngine;

public class EnemyDamageOnTouch : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Damage")]
    public int contactDamage = 1;

    [Header("Knockback")]
    public bool applyKnockback = true;
    public float knockbackDistance = 0.5f;

    [Header("Audio Feedback")]
    public AudioSource audioSource;
    public AudioClip hitSound;

    [Range(0f, 1f)]
    public float hitSoundVolume = 1f;

    [Header("Debug")]
    public bool showDebugLogs = true;

    private void Start()
    {
        // TODO: Check if audioSource is null.
        // If it is, get the AudioSource component from this GameObject.


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO: Check whether the object involved in the collision
        // has the Player tag.
        // If it does not, stop this function.



        // TODO: Get the PlayerHealth component from the
        // object involved in the collision.
        PlayerHealth playerHealth = null;



        // TODO: Check that playerHealth is not null.
        // If it exists:
        // - Damage the player using contactDamage.
        // - Call PlayHitSound.
        // - Print the damage dealt if debug logs are enabled.





        // TODO: Check whether knockback is enabled.
        if (applyKnockback == true)
        {
            // TODO: Get the Rigidbody2D attached to the player's collider.
            Rigidbody2D playerRb = null;



            // TODO: Check that playerRb is not null.
            if (playerRb != null)
            {
                // Calculate the direction from the enemy to the player.
                Vector2 direction = (playerRb.position - (Vector2)transform.position).normalized;

                // Calculate where the Rigidbody2D should move to.
                Vector2 targetPosition = playerRb.position + direction * knockbackDistance;

                // TODO: Move the player's Rigidbody2D to targetPosition. Hint you'll need to use the Move Function of rigidbody.



                // TODO: If debug logs are enabled,
                // print the new knockback position.


            }
        }
    }

    private void PlayHitSound()
    {
        // TODO: Check whether audioSource is null.
        // If it is, stop this function.



        // TODO: Check whether hitSound is null.
        // If it is, stop this function.



        // TODO: Play hitSound using the AudioSource
        // and the hitSoundVolume.



        // TODO: If debug logs are enabled,
        // print that the hit sound played.


    }
}