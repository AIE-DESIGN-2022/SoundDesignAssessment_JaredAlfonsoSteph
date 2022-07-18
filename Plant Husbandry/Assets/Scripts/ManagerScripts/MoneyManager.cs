using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour
{
    public int currentMoney;
    public TextMeshProUGUI playerMoneyAmountText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMoneyText();
    }

    public void DecreaseMoney(int moneyToTake)
    {
       
       // {
//
       // }
       // else
       // {
            currentMoney -= moneyToTake;
            UpdateMoneyText();
     
        


    }

    private void Update()
    {
        if (currentMoney <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("LoseScene");
        }
    }

    public void IncreaseMoney(int moneyToAdd)
    {
        currentMoney += moneyToAdd;
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        playerMoneyAmountText.text = "$" + currentMoney;
    }

    
}
