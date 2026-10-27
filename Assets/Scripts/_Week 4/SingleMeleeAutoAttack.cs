using UnityEngine;

public class SingleMeleeAutoAttack : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("References")]
    public GameObject slashPrefab;
    public SpriteRenderer playerSpriteRenderer;

    [Header("Animation")]
    public Animator animator;
    public bool useAttackAnimation = true;
    public string attackTriggerName = "Attack";

    [Header("Facing")]
    public bool facingRight = true;
    public bool faceRightByDefault = true;

    [Header("Attack Settings")]
    public bool attacksEnabled = true;
    public int damage = 5;
    public float cooldown = 1f;

    [Header("Slash Position")]
    public float slashOffsetX = 1f;
    public float slashOffsetY = 0f;

    [Header("Slash Visual")]
    public bool flipSlashWhenFacingLeft = true;

    [Header("Debug")]
    public bool showDebugLogs = true;

    [Header("Debug View")]
    public float attackTimer = 0f;

    private void Start()
    {
        // TODO: Check if playerSpriteRenderer is null.
        // If it is, get the SpriteRenderer from this GameObject or its children.



        // Get the Animator if one has not been assigned.
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }

        // TODO: Set the attack timer to the cooldown value.



        if (showDebugLogs == true)
        {
            Debug.Log("SingleMeleeAutoAttack: Started. Damage = " + damage + ", Cooldown = " + cooldown);
        }
    }

    private void Update()
    {
        UpdateFacingFromSprite();
        UpdateAutoAttack();
    }

    private void UpdateFacingFromSprite()
    {
        if (playerSpriteRenderer == null)
        {
            return;
        }

        // TODO: Check whether the player's sprite faces right by default.
        if (faceRightByDefault == true)
        {
            // TODO: Set facingRight based on whether the SpriteRenderer is flipped.


        }
        else
        {
            // TODO: Set facingRight based on whether the SpriteRenderer is flipped.


        }
    }

    private void UpdateAutoAttack()
    {
        if (attacksEnabled == false)
        {
            return;
        }

        // Reduce the attack timer each frame.
        attackTimer -= Time.deltaTime;

        // When the timer reaches 0, attack and reset the timer.
        if (attackTimer <= 0f)
        {
            // TODO: Call the Attack function.



            // TODO: Reset attackTimer to the cooldown value.


        }
    }

    private void Attack()
    {
        // TODO: Call the function that performs the melee slash.



        // TODO: Call the function that plays the attack animation.


    }

    private void PlayAttackAnimation()
    {
        if (useAttackAnimation == false)
        {
            return;
        }

        if (animator == null)
        {
            if (showDebugLogs == true)
            {
                Debug.LogWarning("SingleMeleeAutoAttack: No Animator found.");
            }

            return;
        }

        // Play the attack animation.
        animator.SetTrigger(attackTriggerName);

        if (showDebugLogs == true)
        {
            Debug.Log("SingleMeleeAutoAttack: Attack animation triggered.");
        }
    }

    private void PerformSlash()
    {
        if (slashPrefab == null)
        {
            if (showDebugLogs == true)
            {
                Debug.LogWarning("SingleMeleeAutoAttack: No slashPrefab assigned.");
            }

            return;
        }

        // Choose which direction the slash should appear.
        float direction = facingRight ? 1f : -1f;

        Vector3 localSpawnPosition = new Vector3(slashOffsetX * direction, slashOffsetY, 0f);

        // Create the slash as a child of the player.
        GameObject slashObj = Instantiate(slashPrefab, transform);

        slashObj.transform.localPosition = localSpawnPosition;
        slashObj.transform.localRotation = Quaternion.identity;

        if (flipSlashWhenFacingLeft == true)
        {
            // TODO: Get the SpriteRenderer from the slash object.
            SpriteRenderer slashRenderer = null;

            // TODO: Check that slashRenderer is not null.
            // If it exists, set its flipX value based on facingRight.


        }

        // TODO: Get the MeleeSlash script from the slash object.
        MeleeSlash slash = null;

        // TODO: Check that slash is not null.
        // If it exists, call Initialize and give it the player's damage.


        if (showDebugLogs == true)
        {
            Debug.Log("SingleMeleeAutoAttack: Auto slash spawned. FacingRight = " + facingRight + ", Damage = " + damage);
        }
    }
}