using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyChase : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Movement")]
    public float moveSpeed = 2f;

    [Header("Target")]
    public Transform target;

    [Header("Animation")]
    public Animator animator;
    public string isMovingParameter = "isMoving";

    [Header("Sprite")]
    public SpriteRenderer spriteRenderer;
    public bool faceRightByDefault = true;

    private Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Awake()
    {
        // TODO: Get the Rigidbody2D component from this GameObject.



        // TODO: Check if animator is null.
        // If it is, get the Animator component from this GameObject.



        // TODO: Check if spriteRenderer is null.
        // If it is, get the SpriteRenderer from this GameObject or its children.


    }

    private void Start()
    {
        // Check if a target has not been assigned.
        if (target == null)
        {
            // TODO: Find the GameObject with the Player tag.
            GameObject playerObject = null;

            // TODO: Check that playerObject is not null.
            // If it exists, set target to the player's Transform.


        }
    }

    private void FixedUpdate()
    {
        // TODO: Check if target is null.
        // If it is, stop the enemy moving and stop this function.



        // TODO: Calculate the direction from the enemy to the target.
        // Normalise the direction and store it in moveDirection.



        // TODO: Move the enemy using moveDirection and moveSpeed.



        // TODO: Call the function that updates the animation.



        // TODO: Call the function that updates the sprite direction.


    }

    private void UpdateAnimation()
    {
        if (animator == null)
        {
            return;
        }

        // TODO: Create a bool that checks whether the enemy is moving.
        bool isMoving = false;

        // TODO: Update the Animator's isMoving parameter.


    }

    private void UpdateSpriteFlip()
    {
        if (spriteRenderer == null)
        {
            return;
        }

        // Only change direction when moving left or right.
        if (moveDirection.x > 0f)
        {
            // TODO: Set flipX so the enemy faces right.


        }
        else if (moveDirection.x < 0f)
        {
            // TODO: Set flipX so the enemy faces left.


        }
    }
}