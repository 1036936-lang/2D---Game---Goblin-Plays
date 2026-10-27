using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerKills : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Kills")]
    public int currentKills = 0;

    [Header("Kills UI")]
    public TMP_Text killsText;
    public bool useKillsText = true;
    public string killsPrefix = "Kills: ";

    [Header("Debug")]
    public bool enableDebugKeys = true;
    public bool showDebugLogs = true;
    public int debugAddAmount = 1;
    public Key addKillKey = Key.B;
    public Key resetKillsKey = Key.V;

    [Header("Game Over Kills UI")]
    public TMP_Text gameOverKillsText;

    private void Start()
    {
        // TODO: Call the function that updates the kills UI.



        if (showDebugLogs == true)
        {
            Debug.Log("PlayerKills: Starting kills = " + currentKills);
        }
    }

    private void Update()
    {
        if (enableDebugKeys == true)
        {
            HandleDebugInput();
        }
    }

    private void HandleDebugInput()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        // If the Add Kill key is pressed,
        // call the function that adds kills.
        if (Keyboard.current[addKillKey].wasPressedThisFrame)
        {
            // TODO: Call AddKills and give it debugAddAmount.


        }

        // If the Reset Kills key is pressed,
        // call the function that resets the player's kills.
        if (Keyboard.current[resetKillsKey].wasPressedThisFrame)
        {
            // TODO: Call ResetKills.


        }
    }

    public void AddKills(int amount)
    {
        if (amount < 0)
        {
            return;
        }

        // TODO: Add amount to the player's current kills.



        // TODO: Call the function that updates the kills UI.


    }

    public void ResetKills()
    {
        // TODO: Set the player's current kills back to 0.



        // TODO: Call the function that updates the kills UI.


    }

    public void DebugAddKill()
    {
        // TODO: Call AddKills and give it debugAddAmount.


    }

    private void UpdateKillsUI()
    {
        if (useKillsText == false)
        {
            return;
        }

        // TODO: Update the kills text using killsPrefix
        // and the player's current kills.

        if (killsText == null)
        {
            return;
        }

        if (gameOverKillsText != null)
        {
            // TODO: Display the player's total kills
            // on the Game Over screen.


        }
    }
}