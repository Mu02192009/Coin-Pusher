using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] CoinManager coinManager;

    [SerializeField] int startCoinCount = 30;

    void Start()
    {
        for (int i = 0; i < startCoinCount; i++)
        {
            SpawnCoin();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coinManager.UseCoin(1))
            {
                SpawnCoin();
            }
        }
    }

    void SpawnCoin()
    {
        float x = Random.Range(-3f, 3f);
        float y = Random.Range(2f, 5f);
        float z = Random.Range(-3f, 3f);

        Instantiate(
            coinPrefab,
            new Vector3(x, 5f, z),
            Quaternion.identity
        );
    }
}
