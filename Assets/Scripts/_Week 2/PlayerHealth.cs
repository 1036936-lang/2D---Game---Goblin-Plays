using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Health")]
    public int maxHP = 10;
    public int currentHP;

    [Header("Health UI")]
    public Slider healthSlider;
    public bool useHealthSlider = true;

    public TMP_Text healthText;
    public bool useHealthText = true;

    [Header("Hit Flash")]
    public SpriteRenderer spriteRenderer;
    public bool useHitFlash = true;
    public Color hitFlashColor = Color.red;
    public float flashDuration = 0.1f;

    [Header("Audio Feedback")]
    public AudioSource audioSource;
    public AudioClip damageSound;
    public AudioClip healSound;
    public AudioClip deathSound;

    [Header("Death Animation")]
    public Animator animator;
    public bool useDeathAnimation = true;
    public string deathAnimationName = "Death";
    public float deathDelay = 1.2f;

    [Header("Game Over")]
    public bool disableMovementOnDeath = true;
    public bool disableAttackOnDeath = true;

    [Header("References")]
    public PlayerMovement movement;
    public SingleMeleeAutoAttack meleeAutoAttack;
    public GameManager gameManager;

    [Header("Debug")]
    public bool enableDebugKeys = true;
    public bool showDebugLogs = true;

    public Key debugDamageKey = Key.Space;
    public int minimumDebugDamage = 1;
    public int maximumDebugDamage = 3;

    public Key debugHealKey = Key.H;
    public int minimumDebugHeal = 1;
    public int maximumDebugHeal = 3;

    public bool isDead { get; private set; }

    private Color originalColor;
    private Coroutine flashRoutine;

    private void Start()
    {
        // TODO: Set the player's current health to their maximum health.



        // TODO: Print the player's starting health to the Console.



        if (movement == null)
        {
            movement = GetComponent<PlayerMovement>();
        }

        if (meleeAutoAttack == null)
        {
            meleeAutoAttack = GetComponent<SingleMeleeAutoAttack>();
        }

        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }

        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }

        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        SetupHealthUI();
        UpdateHealthUI();
    }

    private void Update()
    {
        HandleDebugInput();
    }

    private void HandleDebugInput()
    {
        if (enableDebugKeys == false || isDead == true)
        {
            return;
        }

        if (Keyboard.current == null)
        {
            return;
        }

        // If the debug damage key is pressed,
        // call the function that damages the player.
        if (Keyboard.current[debugDamageKey].wasPressedThisFrame)
        {
            DebugDamage();
        }

        // If the debug heal key is pressed,
        // call the function that heals the player.
        if (Keyboard.current[debugHealKey].wasPressedThisFrame)
        {
            DebugHeal();
        }
    }

    private void SetupHealthUI()
    {
        if (useHealthSlider == true && healthSlider != null)
        {
            healthSlider.minValue = 0;

            // TODO: Set the slider's maximum value to the player's maximum health.
            healthSlider.maxValue = 0;

            // TODO: Set the slider's current value to the player's current health.
            healthSlider.value = 0;
        }
    }

    private void UpdateHealthUI()
    {
        if (useHealthSlider == true && healthSlider != null)
        {
            // TODO: Set the slider's maximum value to the player's maximum health.
            healthSlider.maxValue = 0;

            // TODO: Set the slider's current value to the player's current health.
            healthSlider.value = 0;
        }

        if (useHealthText == true && healthText != null)
        {
            healthText.text = "HP: " + currentHP + "/" + maxHP;
        }
    }

    public void DebugDamage()
    {
        // TODO: Give damageAmount a random value between
        // minimumDebugDamage and maximumDebugDamage.
        // Include both the minimum and maximum values.
        int damageAmount = 0;



        // TODO: Print the randomly generated damage amount to the Console.



        TakeDamage(damageAmount);
    }

    public void DebugHeal()
    {
        // TODO: Give healAmount a random value between
        // minimumDebugHeal and maximumDebugHeal.
        // Include both the minimum and maximum values.
        int healAmount = 0;



        // TODO: Print the randomly generated healing amount to the Console.



        Heal(healAmount);
    }

    public void TakeDamage(int amount)
    {
        if (isDead == true)
        {
            return;
        }

        // TODO: Subtract the damage amount from the player's current health.



        // TODO: Check whether the player's health is below zero.
        // If it is, set the player's health to zero.



        // TODO: If debug logs are enabled, print the amount of damage taken
        // and the player's current health.



        UpdateHealthUI();
        PlayDamageSound();

        if (useHitFlash == true)
        {
            StartHitFlash();
        }

        if (currentHP <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (isDead == true)
        {
            return;
        }

        // TODO: Add the healing amount to the player's current health.



        // TODO: Check whether the player's health is greater than maxHP.
        // If it is, set it back to maxHP.



        // TODO: If debug logs are enabled, print the amount healed
        // and the player's current health.



        UpdateHealthUI();
        PlayHealSound();
    }

    private void PlayDamageSound()
    {
        if (audioSource == null)
        {
            return;
        }

        if (damageSound == null)
        {
            return;
        }

        audioSource.PlayOneShot(damageSound);

        if (showDebugLogs == true)
        {
            Debug.Log("PlayerHealth: Damage sound played.");
        }
    }

    private void PlayHealSound()
    {
        if (audioSource == null)
        {
            return;
        }

        if (healSound == null)
        {
            return;
        }

        audioSource.PlayOneShot(healSound);

        if (showDebugLogs == true)
        {
            Debug.Log("PlayerHealth: Heal sound played.");
        }
    }

    private void PlayDeathSound()
    {
        if (audioSource == null)
        {
            return;
        }

        if (deathSound == null)
        {
            return;
        }

        audioSource.PlayOneShot(deathSound);

        if (showDebugLogs == true)
        {
            Debug.Log("PlayerHealth: Death sound played.");
        }
    }

    private void StartHitFlash()
    {
        if (spriteRenderer == null)
        {
            return;
        }

        // Only start the hit flash if one is not already running.
        if (flashRoutine == null)
        {
            flashRoutine = StartCoroutine(FlashOnHit());
        }
    }

    private IEnumerator FlashOnHit()
    {
        spriteRenderer.color = hitFlashColor;

        yield return new WaitForSeconds(flashDuration);

        if (spriteRenderer != null)
        {
            spriteRenderer.color = originalColor;
        }

        // Allow the hit flash to be started again.
        flashRoutine = null;
    }

    private void Die()
    {
        if (isDead == true)
        {
            return;
        }

        isDead = true;

        if (showDebugLogs == true)
        {
            Debug.Log("PlayerHealth: Player died!");
        }

        PlayDeathSound();

        if (disableMovementOnDeath == true && movement != null)
        {
            movement.enabled = false;
        }

        if (disableAttackOnDeath == true && meleeAutoAttack != null)
        {
            meleeAutoAttack.attacksEnabled = false;
            meleeAutoAttack.enabled = false;
        }

        if (useDeathAnimation == true && animator != null)
        {
            animator.Play(deathAnimationName);

            if (showDebugLogs == true)
            {
                Debug.Log("PlayerHealth: Playing death animation: " + deathAnimationName);
            }
        }

        StartCoroutine(ShowGameOverAfterDelay());
    }

    private IEnumerator ShowGameOverAfterDelay()
    {
        yield return new WaitForSeconds(deathDelay);

        if (gameManager != null)
        {
            gameManager.GameOver();
        }
    }
}