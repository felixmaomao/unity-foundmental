using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceToJump : MonoBehaviour {


     Rigidbody2D rigid;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            AddUpperForce();
        }	
	}

    void AddUpperForce()
    {
        rigid.AddForce(Vector2.up,ForceMode2D.Impulse);
    }
}
