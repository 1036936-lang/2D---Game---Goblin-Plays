using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    // Complete each section marked TODO.

    [Header("Money")]
    public int startingMoney = 0;
    public int currentMoney;

    [Header("Money UI")]
    public TMP_Text moneyText;
    public bool useMoneyText = true;
    public string moneyPrefix = "Gold: ";

    [Header("Debug")]
    public bool enableDebugKeys = true;
    public bool showDebugLogs = true;

    public int debugAddAmount = 10;
    public int debugSpendAmount = 5;

    public Key addMoneyKey = Key.M;
    public Key spendMoneyKey = Key.N;

    [Header("Game Over Money UI")]
    public TMP_Text gameOverMoneyText;

    private void Start()
    {
        // TODO: Set the player's current money
        // to their starting money.



        // TODO: Call the function that updates the money UI.



        if (showDebugLogs)
        {
            Debug.Log("PlayerMoney: starting money = " + currentMoney);
        }
    }

    private void Update()
    {
        if (enableDebugKeys)
        {
            HandleDebugInput();
        }
    }

    private void HandleDebugInput()
    {
        // If the Add Money key is pressed,
        // call AddMoney and give it debugAddAmount.
        if (Keyboard.current[addMoneyKey].wasPressedThisFrame)
        {
            // TODO: Call AddMoney and give it debugAddAmount.

        }

        // If the Spend Money key is pressed,
        // call SpendMoney and give it debugSpendAmount.
        if (Keyboard.current[spendMoneyKey].wasPressedThisFrame)
        {
            // TODO: Call SpendMoney and give it debugSpendAmount.

        }
    }

    public void AddMoney(int amount)
    {
        if (amount < 0)
        {
            return;
        }

        // TODO: Add amount to the player's current money.



        // TODO: Call the function that updates the money UI.


    }

    public bool CanAfford(int amount)
    {
        // TODO: Return true if the player has enough money
        // to afford the amount.

        return false;
    }

    public bool SpendMoney(int amount)
    {
        if (amount < 0)
        {
            return false;
        }

        // Check whether the player can afford the amount.
        if (!CanAfford(amount))
        {
            if (showDebugLogs)
            {
                Debug.Log(
                    "PlayerMoney: Cannot afford " + amount +
                    ". Current money: " + currentMoney
                );
            }

            return false;
        }

        // TODO: Subtract amount from the player's current money.



        // TODO: Call the function that updates the money UI.



        return true;
    }

    private void UpdateMoneyUI()
    {
        if (!useMoneyText)
        {
            return;
        }

        if (moneyText == null)
        {
            return;
        }

        // TODO: Update the money text using moneyPrefix
        // and the player's current money.



        if (gameOverMoneyText != null)
        {
            // TODO: Display the player's current money
            // on the Game Over screen.

        }
    }
}