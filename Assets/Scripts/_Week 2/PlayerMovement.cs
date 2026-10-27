using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Movement")]
    public float moveSpeed = 5f;

    [Header("Animation")]
    public Animator animator;
    public string isMovingParameter = "isMoving";

    [Header("Sprite")]
    public SpriteRenderer spriteRenderer;
    public bool faceRightByDefault = true;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }
    }

    private void Update()
    {
        ReadMovementInput();
        UpdateAnimation();
        UpdateSpriteFlip();
    }

    private void ReadMovementInput()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        // These variables store the player's horizontal and vertical movement directions.
        float x = 0f;
        float y = 0f;

        // Check whether the player is holding W or the Up Arrow.
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            // Set the vertical movement direction to move up.
            y = 1f;
        }

        // TODO: Add an if statement that checks whether the player
        // is holding S or the Down Arrow.
        // Set the vertical movement direction to move down.



        // TODO: Add an if statement that checks whether the player
        // is holding A or the Left Arrow.
        // Set the horizontal movement direction to move left.



        // TODO: Add an if statement that checks whether the player
        // is holding D or the Right Arrow.
        // Set the horizontal movement direction to move right.



        // Combine the horizontal and vertical values into one movement direction.
        moveInput = new Vector2(x, y);

        // Stop diagonal movement from being faster.
        if (moveInput.sqrMagnitude > 1f)
        {
            moveInput = moveInput.normalized;
        }
    }

    private void FixedUpdate()
    {
        // Apply the movement direction and speed to the Rigidbody.
        rb.linearVelocity = moveInput * moveSpeed;
    }

    private void UpdateAnimation()
    {
        if (animator == null)
        {
            return;
        }

        // Check whether the player is currently moving.
        bool isMoving = moveInput.sqrMagnitude > 0f;

        // Update the movement animation.
        animator.SetBool(isMovingParameter, isMoving);
    }

    private void UpdateSpriteFlip()
    {
        if (spriteRenderer == null)
        {
            return;
        }

        // Only flip when moving left or right.
        // This prevents the sprite from flipping when moving up or down.
        if (moveInput.x > 0f)
        {
            spriteRenderer.flipX = !faceRightByDefault;
        }
        else if (moveInput.x < 0f)
        {
            spriteRenderer.flipX = faceRightByDefault;
        }
    }
}