using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    private int moveSpeed;
    private int damage;

    private int side; // 1 = Left, 2 = Right

    public GameObject player;

	void Start () {
        //player = GetComponent<PlayerMovement>();
        WhatSideAmI();
	}
	

    void OnColliderEnter()
    {

    }

    void WhatSideAmI()
    {
        if (this.transform.position.x >= player.transform.position.x)   //Replace "player.transform.position.x" with "player.xPos"
        {
            moveLeft();
        }
        else
        {
            moveRight();
        }
    }

    void Destroy()
    {
        Destroy(this);
    }

    void moveLeft()
    {

        Invoke("moveLeft", 0.0f);
    }

    void moveRight()
    {
        Invoke("moveRight", 0.0f);
    }


}
