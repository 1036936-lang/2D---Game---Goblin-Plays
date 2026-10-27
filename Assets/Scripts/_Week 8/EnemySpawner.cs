using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemySpawner : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Spawner Settings")]
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnRadius = 8f;

    [Header("Animation")]
    public Animator animator;
    public bool playIdleAnimationOnStart = true;
    public string idleAnimationName = "Idle";

    [Header("Spawn Feedback")]
    public GameObject spawnParticlePrefab;
    public float spawnParticleLifetime = 2f;
    public AudioClip spawnSound;
    public AudioSource audioSource;

    [Header("Game Manager")]
    public GameManager gameManager;

    [Header("Debug")]
    public bool spawningEnabled = true;
    public bool enableDebugKeys = true;
    public bool showDebugLogs = true;

    public Key toggleSpawnKey = Key.P;
    public Key spawnOnceKey = Key.O;
    public Key destroyEnemiesKey = Key.I;

    [Header("Debug View")]
    public float spawnTimer = 0f;

    // This collection stores all enemies created by this spawner.
    public List<GameObject> spawnedEnemies = new List<GameObject>();

    private void Awake()
    {
        // TODO: Check if audioSource is null.
        // If it is, get the AudioSource component from this GameObject.



        // TODO: Check if animator is null.
        // If it is, get the Animator component from this GameObject.



        // TODO: Check if gameManager is null.
        // If it is, find the GameManager in the scene.


    }

    private void Start()
    {
        // TODO: Call the function that plays the idle animation.



        // TODO: If debug logs are enabled, print that the EnemySpawner has started.



        // TODO: Check that gameManager is not null.
        // If it exists, call AddSpawner.


    }

    private void Update()
    {
        // TODO: Call the function that handles the debug input.



        // TODO: Check whether spawning is disabled.
        // If it is, stop this function.



        // TODO: Check whether enemyPrefab is null.
        // If it is:
        // - Print a warning if debug logs are enabled.
        // - Stop this function.



        // TODO: Add Time.deltaTime to spawnTimer.



        // TODO: Check whether spawnTimer is greater than or equal to spawnInterval.
        // If it is:
        // - Reset spawnTimer to 0.
        // - Call SpawnEnemy.


    }

    private void PlayIdleAnimation()
    {
        // TODO: Check whether playIdleAnimationOnStart is false.
        // If it is, stop this function.



        // TODO: Check whether animator is null.
        // If it is:
        // - Print a warning if debug logs are enabled.
        // - Stop this function.



        // TODO: Check whether idleAnimationName is empty.
        // Hint: Use string.IsNullOrWhiteSpace().
        // If it is:
        // - Print a warning if debug logs are enabled.
        // - Stop this function.



        // TODO: Play the animation stored in idleAnimationName.



        // TODO: If debug logs are enabled, print the animation being played.


    }

    private void HandleDebugInput()
    {
        // TODO: Check whether debug keys are disabled.
        // If they are, stop this function.



        // TODO: Check whether Keyboard.current is null.
        // If it is, stop this function.



        // TODO: Check whether toggleSpawnKey was pressed.
        // If it was:
        // - Toggle spawningEnabled between true and false.
        // - Print the new value if debug logs are enabled.



        // TODO: Check whether spawnOnceKey was pressed.
        // If it was:
        // - Call SpawnEnemy.
        // - Print a debug message if debug logs are enabled.



        // TODO: Check whether destroyEnemiesKey was pressed.
        // If it was, call DestroySpawnedEnemies.


    }

    public void StopSpawning()
    {
        // TODO: Set spawningEnabled to false.



        // TODO: If debug logs are enabled, print that spawning has stopped.


    }

    public void SpawnerDestroyed()
    {
        // TODO: Check that gameManager is not null.
        // If it exists, call RemoveSpawner.


    }

    private void SpawnEnemy()
    {
        // TODO: Check whether enemyPrefab is null.
        // If it is:
        // - Print a warning if debug logs are enabled.
        // - Stop this function.



        // Generate a random position inside the spawn radius.
        Vector2 randomOffset = Random.insideUnitCircle * spawnRadius;

        // TODO: Calculate the final spawn position using
        // this GameObject's position and randomOffset.
        Vector3 spawnPosition = new Vector3(0, 0, 0);



        // TODO: Instantiate enemyPrefab at spawnPosition.
        // Store the newly created GameObject in enemyObject.
        GameObject enemyObject = null;



        // TODO: Add enemyObject to the spawnedEnemies collection.



        // TODO: Call PlaySpawnFeedback and give it spawnPosition.



        // TODO: If debug logs are enabled, print where the enemy spawned.


    }

    public void DestroySpawnedEnemies()
    {
        // Loop through every GameObject in the spawnedEnemies collection.
        for (int i = 0; i < spawnedEnemies.Count; i++)
        {
            // TODO: Check that the enemy at position i is not null.



            // TODO: Destroy the enemy at position i.


        }

        // TODO: Clear the spawnedEnemies collection.



        // TODO: If debug logs are enabled, print that all spawned enemies were destroyed.


    }

    private void PlaySpawnFeedback(Vector3 spawnPosition)
    {
        // TODO: Check that spawnParticlePrefab is not null.
        if (spawnParticlePrefab != null)
        {
            // TODO: Instantiate spawnParticlePrefab at spawnPosition.
            // Store the newly created GameObject in particleObject.
            GameObject particleObject = null;



            // TODO: Destroy particleObject after spawnParticleLifetime seconds.


        }

        // TODO: Check that spawnSound and audioSource are not null.
        // If they exist, play spawnSound using the AudioSource.



        // TODO: If debug logs are enabled, print that the spawn feedback played.


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }
}