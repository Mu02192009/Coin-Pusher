using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] int Coin = 50;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCoinText();
    }

    public bool UseCoin(int amount)
    {
        if (Coin < amount)
        {
            return false;
        }

        Coin -= amount;

        UpdateCoinText();

        return true;
    }

    void UpdateCoinText()
    {
        coinText.text = "Coin : " + Coin;
    }

    public void AddCoin(int amount)
    {
        Coin += amount;

        UpdateCoinText();
    }
}
