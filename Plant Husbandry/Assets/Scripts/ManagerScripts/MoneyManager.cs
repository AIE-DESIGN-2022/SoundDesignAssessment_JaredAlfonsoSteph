using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MoneyManager : MonoBehaviour
{
    public int currentMoney;
    public TextMeshProUGUI playerMoneyAmountText;
    public AudioSource spendMoneySound;
    public AudioSource earnMoneySound;

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
     
        spendMoneySound.Play();


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
        earnMoneySound.Play();
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        playerMoneyAmountText.text = "$" + currentMoney;
    }

    
}
