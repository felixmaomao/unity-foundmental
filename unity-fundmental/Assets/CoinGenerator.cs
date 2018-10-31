using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public GameObject coinPrefab;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 200; i++)
        {
            Instantiate(coinPrefab, this.gameObject.transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
