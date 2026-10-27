using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CoinPickup : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Coin Settings")]
    public int moneyAmount = 1;

    [Header("Debug")]
    public bool showDebugLogs = true;

    private void Awake()
    {
        // TODO: Get the Collider2D component from this GameObject.
        Collider2D col = null;



        // TODO: Check that col is not null.
        // If it exists, set the Collider2D to be a trigger.


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // TODO: Check whether the object that entered the trigger
        // has the Player tag.
        // If it does not, stop this function.



        // TODO: Get the PlayerMoney component from the object
        // that entered the trigger.
        PlayerMoney money = null;



        // TODO: If money is null, try to find the
        // PlayerMoney component in the scene.



        // TODO: Check that money is not null.
        // If it exists:
        // - Add moneyAmount to the player's money.
        // - Print a debug message if debug logs are enabled.





        // Remove the coin after it has been collected.
        Destroy(gameObject);
    }
}