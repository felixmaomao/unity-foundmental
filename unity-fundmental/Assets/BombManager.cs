using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{

    public GameObject explosionPrefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("bomb");
            Explode();
        }
    }

    void Explode()
    {
        GameObject explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        //炸弹炸完了，自身得消失
        gameObject.SetActive(false);
        Destroy(explosion,0.3f);
    }
}
