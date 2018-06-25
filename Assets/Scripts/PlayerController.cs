using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour {
    GameObject player;
    Rigidbody2D rb;

    private float xMaxSpeed = 3.0f;
    private float yMaxSpeed = 3.0f;

	void Start () {
 //       this.player = GameObject.Find("Player");
        this.rb = GetComponent<Rigidbody2D>();
	}

    private void Move(float x, float y){
        this.rb.velocity = new Vector2(xMaxSpeed * x, yMaxSpeed * y);
    }

    void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Move(x, y);
	}
}
