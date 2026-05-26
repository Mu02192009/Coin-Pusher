using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Coin"))
        {
            coinManager.AddCoin(1);

            Destroy(other.gameObject);
        }
    }
}
