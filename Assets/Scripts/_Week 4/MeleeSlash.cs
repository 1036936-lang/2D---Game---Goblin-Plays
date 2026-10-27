using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class MeleeSlash : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Slash Settings")]
    public float lifetime = 0.25f;
    public int damage = 5;

    [Header("Debug")]
    public bool showDebugLogs = true;

    private void Awake()
    {
        // TODO: Get the Collider2D component from this GameObject.
        Collider2D col = null;

        // TODO: Check that col is not null.
        // If it exists, set it to be a trigger.


    }

    private void Start()
    {
        // Remove the slash after its lifetime has passed.
        Destroy(gameObject, lifetime);
    }

    public void Initialize(int damageAmount)
    {
        // TODO: Set damage to the damageAmount passed into this function.


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Try to get the EnemyHealth component from the object that entered the trigger.
        EnemyHealth enemy = null;

        // TODO: Check that enemy is not null.
        if (enemy != null)
        {
            // TODO: Call the enemy's TakeDamage function and give it this slash's damage amount.


            // TODO: If debug logs are enabled, print the enemy hit and damage dealt.


        }
    }
}